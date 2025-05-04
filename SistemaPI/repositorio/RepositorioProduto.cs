using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using SistemaPI.banco_de_dados;
using SistemaPI.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaPI.repositorio
{
    internal class RepositorioProduto
    {
        
        public List<Produto> ListarProdutos()
        {
            var produtos = new List<Produto>();

            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string query = @"
                                SELECT 
                                    produto.id AS produto_id,
                                    produto.nome AS produto_nome,
                                    produto.preco AS produto_preco,
                                    fornecedor.id AS fornecedor_id,
                                    fornecedor.nome AS fornecedor_nome
                                FROM produto
                                JOIN fornecedor ON produto.fornecedor_id = fornecedor.id;";

                using var cmd = new MySqlCommand(query, conection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    produtos.Add(new Produto
                    {
                        Id = reader.GetInt32("produto_id"),
                        Nome = reader.GetString("produto_nome"),
                        Preco = reader.GetDecimal("produto_preco"),
                        Fornecedor = new Fornecedor
                        {
                            Id = reader.GetInt32("fornecedor_id"),
                            Nome = reader.GetString("fornecedor_nome")
                        }
                    });
                }
            }

            return produtos;
        }


        public void InserirProduto(Produto novoProduto)
        {
            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string queryProduto = "INSERT INTO produto (nome , preco, fornecedor_id) " +
                                        "VALUES (@nome, @preco, @fornecedor_id);";

                using (var cmd = new MySqlCommand(queryProduto, conection))
                {
                    cmd.Parameters.AddWithValue("@nome", novoProduto.Nome);
                    cmd.Parameters.AddWithValue("@preco", novoProduto.Preco);
                    cmd.Parameters.AddWithValue("@fornecedor_id", novoProduto.Fornecedor.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Produto? BuscarProdutoPorNome(string nome)
        {
            string query = @"
                            SELECT 
                                produto.id AS produto_id,
                                produto.nome AS produto_nome,
                                produto.preco AS produto_preco,
                                fornecedor.id AS fornecedor_id,
                                fornecedor.nome AS fornecedor_nome
                            FROM produto
                            JOIN fornecedor ON produto.fornecedor_id = fornecedor.id
                            WHERE produto.nome = @param;";
            return BuscarProdutoPorUnique(query, nome);
        }

        public Produto? BuscarProdutoPorId(int id)
        {
            string query = @"
                            SELECT 
                                produto.id AS produto_id,
                                produto.nome AS produto_nome,
                                produto.preco AS produto_preco,
                                fornecedor.id AS fornecedor_id,
                                fornecedor.nome AS fornecedor_nome
                            FROM produto
                            JOIN fornecedor ON produto.fornecedor_id = fornecedor.id
                            WHERE produto.id = @param;";

            return BuscarProdutoPorUnique(query, id.ToString());
        }


        public void AtualizarProduto(Produto produto)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "UPDATE produto SET nome = @nome, preco = @preco, fornecedor = @fornecedor WHERE id = @id;";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Produto? BuscarProdutoPorUnique(string query, string param)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", param);
                    using var reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new Produto
                    {
                        Nome = reader.GetString("nome"),
                        Preco = reader.GetDecimal("preco"),
                        Fornecedor = new Fornecedor
                        {
                            Id = reader.GetInt32("fornecedor_id"),
                            Nome = reader.GetString("fornecedor_nome")
                        }
                    };
                }
            }
        }


        public void DeletarProduto(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        
                        string queryProdutosPedido = "DELETE FROM produto_pedido WHERE id_produto = @id;";
                        using (var cmdProdutosPedido = new MySqlCommand(queryProdutosPedido, conn, transaction))
                        {
                            cmdProdutosPedido.Parameters.AddWithValue("@id", id);
                            cmdProdutosPedido.ExecuteNonQuery();
                        }

                        
                        string queryProduto = "DELETE FROM produto WHERE id = @id;";
                        using (var cmdProduto = new MySqlCommand(queryProduto, conn, transaction))
                        {
                            cmdProduto.Parameters.AddWithValue("@id", id);
                            cmdProduto.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao deletar o produto: " + ex.Message);
                    }
                }
            }
        }

        public List<Fornecedor> ListarTodosFornecedores()
        {
            var fornecedores = new List<Fornecedor>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM fornecedor";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fornecedores.Add(new Fornecedor
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome")
                    });
                }
            }

            return fornecedores;

        }

    }
}
