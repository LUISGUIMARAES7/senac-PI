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

                string query = "SELECT * FROM produto;";

                using var cmd = new MySqlCommand(query, conection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    produtos.Add(new Produto
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Preco = reader.GetDecimal("preco"),
                        Quantidade = reader.GetInt32("quantidade")
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

                string queryProduto = "INSERT INTO produto (nome , preco, quantidade) " +
                                        "VALUES (@nome, @preco, @quantidade);";

                using (var cmd = new MySqlCommand(queryProduto, conection))
                {
                    cmd.Parameters.AddWithValue("@nome", novoProduto.Nome);
                    cmd.Parameters.AddWithValue("@preco", novoProduto.Preco);
                    cmd.Parameters.AddWithValue("@quantidade", novoProduto.Quantidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Produto? BuscarProdutoPorId(int id)
        {
            string query = "SELECT nome, preco, quantidade FROM produto WHERE id = @param;";
            return BuscarProdutoPorUnique(query, id.ToString());
        }

        public void AtualizarProduto(Produto produto)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "UPDATE produto SET nome = @nome, preco = @preco, quantidade = @quantidade WHERE id = @id;";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.Parameters.AddWithValue("@nome", produto.Nome);
                    cmd.Parameters.AddWithValue("@preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);

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
                        Quantidade = reader.GetInt32("quantidade")
                    };
                }
            }
        }

        public void DeletarProduto(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM produto WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
