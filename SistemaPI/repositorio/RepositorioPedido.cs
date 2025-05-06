using MySql.Data.MySqlClient;
using SistemaPI.banco_de_dados;
using SistemaPI.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SistemaPI.repositorio
{
    internal class RepositorioPedido
    {
        public List<Cliente> ListarTodosClientes()
        {
            var clientes = new List<Cliente>();

            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string query = "SELECT * FROM cliente;";

                using var cmd = new MySqlCommand(query, conection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone")
                    });
                }
            }

            return clientes;
        }

        public List<Produto> ListarTodosProdutos()
        {
            var produtos = new List<Produto>();

            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string query = @"
                                SELECT 
                                    produto.id,
                                    produto.nome,
                                    produto.preco,
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
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Preco = reader.GetDecimal("preco"),
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



        public List<Pedido> ListarPedidos()
        {
            var pedidos = new List<Pedido>();

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string queryPedidos = @"SELECT
                                    pedido.id AS pedido_id,
                                    pedido.data_pedido AS pedido_data,
                                    cliente.id AS cliente_id, 
                                    cliente.nome AS cliente_nome,
                                    cliente.email AS cliente_email,
                                    cliente.telefone AS cliente_telefone,
                                    pedido.total AS pedido_total
                                FROM pedido
                                JOIN cliente ON pedido.cliente_id = cliente.id
                                ORDER BY pedido.data_pedido DESC;";

                using var cmd = new MySqlCommand(queryPedidos, connection);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var pedido = new Pedido
                    {
                        Id = reader.GetInt32("pedido_id"),
                        DataPedido = reader.GetDateTime("pedido_data"),
                        Total = reader.GetDecimal("pedido_total"),
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32("cliente_id"),
                            Nome = reader.GetString("cliente_nome"),
                            Email = reader.GetString("cliente_email"),
                            Telefone = reader.GetString("cliente_telefone")
                        },
                        
                        Produtos = ""
                    };

                    pedidos.Add(pedido);
                }

            }

            using (var connection = Database.GetConnection())
            {
                connection.Open();

                foreach (var pedido in pedidos)
                {
                    string queryProdutos = @"
                                            SELECT 
                                                produto.nome,
                                                produto_pedido.quantidade
                                            FROM produto
                                            JOIN produto_pedido ON produto.id = produto_pedido.id_produto
                                            WHERE produto_pedido.id_pedido = @pedidoId;";

                    using var cmd = new MySqlCommand(queryProdutos, connection);
                    cmd.Parameters.AddWithValue("@pedidoId", pedido.Id);

                    using var reader = cmd.ExecuteReader();
                    var produtos = new List<string>();

                    while (reader.Read())
                    {
                        var produtoComQuantidade = $"{reader.GetString("nome")} {reader.GetInt32("quantidade")}x ";
                        produtos.Add(produtoComQuantidade);
                    }

                    pedido.Produtos = string.Join(", ", produtos);
                }
            }

            return pedidos;
        }


        public void SalvarPedido(Pedido novoPedido)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                string queryPedido = "INSERT INTO pedido (cliente_id, total, data_pedido) VALUES (@cliente_id, @total, @data)";
                MySqlCommand cmdPedido = new MySqlCommand(queryPedido, connection);
                cmdPedido.Parameters.AddWithValue("@cliente_id", novoPedido.Cliente.Id);
                cmdPedido.Parameters.AddWithValue("@total", novoPedido.Total);
                cmdPedido.Parameters.AddWithValue("@data", novoPedido.DataPedido);
                cmdPedido.ExecuteNonQuery();
                long pedidoId = cmdPedido.LastInsertedId;

                foreach (var item in novoPedido.Itens)
                {
                    string sqlProdutoPedido = "INSERT INTO produto_pedido (id_produto, id_pedido, quantidade) VALUES (@id_produto, @id_pedido, @quantidade)";
                    MySqlCommand cmdProduto = new MySqlCommand(sqlProdutoPedido, connection);
                    cmdProduto.Parameters.AddWithValue("@id_produto", item.produto.Id);
                    cmdProduto.Parameters.AddWithValue("@id_pedido", pedidoId);
                    cmdProduto.Parameters.AddWithValue("@quantidade", item.quantidade);
                    cmdProduto.ExecuteNonQuery();
                }
            }
        }

        public void DeletarPedido(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Primeiro deleta os produtos relacionados ao pedido
                        string queryProdutos = "DELETE FROM produto_pedido WHERE id_pedido = @id;";
                        using (var cmdProdutos = new MySqlCommand(queryProdutos, conn, transaction))
                        {
                            cmdProdutos.Parameters.AddWithValue("@id", id);
                            cmdProdutos.ExecuteNonQuery();
                        }

                        // Depois deleta o pedido
                        string queryPedido = "DELETE FROM pedido WHERE id = @id;";
                        using (var cmdPedido = new MySqlCommand(queryPedido, conn, transaction))
                        {
                            cmdPedido.Parameters.AddWithValue("@id", id);
                            cmdPedido.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao deletar o pedido: " + ex.Message);
                    }
                }
            }
        }


        public Pedido? BuscarPedidoPorId(int id)
        {
            string query = @"SELECT 
                                pedido.id AS pedido_id,
                                cliente.nome AS cliente_nome,
                                produto.nome AS produto_nome,
                                produto.preco AS produto_preco,
                                pedido.total AS pedido_total,
                                pedido.data_pedido AS pedido_data
                            FROM
                                pedido
                            JOIN cliente ON pedido.cliente_id = cliente.id
                            JOIN produto_pedido ON pedido.id = produto_pedido.id_pedido
                            JOIN produto ON produto_pedido.id_produto = produto.id;";
            return BuscarPedidoPorUnique(query, id.ToString());
        }



        //private Pedido? BuscarPedidoPorUnique(string query, string param)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();

        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@param", param);
        //            using var reader = cmd.ExecuteReader();
        //            if (!reader.Read())
        //            {
        //                return null;
        //            }

        //            return new Pedido
        //            {
        //                Id = reader.GetInt32("pedido_id"),
        //                Total = reader.GetDecimal("pedido_total"),
        //                DataPedido = reader.GetDateTime("pedido_data"),
        //                Cliente = new Cliente
        //                {
        //                    Id = reader.GetInt32("cliente_id"),
        //                    Nome = reader.GetString("cliente_nome"),
        //                    Email = reader.GetString("cliente_email"),
        //                    Telefone = reader.GetString("cliente_telefone")
        //                }
        //            };
        //        }
        //    }
        //}

        private Pedido? BuscarPedidoPorUnique(string query, object param)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", param);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        return new Pedido
                        {
                            Id = reader.GetInt32("pedido_id"),
                            Total = reader.GetDecimal("pedido_total"),
                            DataPedido = reader.GetDateTime("pedido_data"),
                            Cliente = new Cliente
                            {
                                // OBS: Só temos o nome na query
                                Nome = reader.GetString("cliente_nome")
                            }
                        };
                    }
                }
            }
        }



    }
}
