using MySql.Data.MySqlClient;
using SistemaPI.banco_de_dados;
using SistemaPI.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPI.repositorio
{
    internal class Repositorio
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
                        Preco = reader.GetInt32("preco"),
                        Quantidade = reader.GetInt32("quantidade")
                    });
                }
            }

            return produtos;
        }

        public void InserirProduto (Produto novoProduto)
        {
            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string queryProduto = "INSERT INTO produto (nome , preco, quantidade) " +
                                        "VALUES (@nome, @preco, @quantidade);";

                using (var cmd = new MySqlCommand( queryProduto, conection))
                {
                    cmd.Parameters.AddWithValue("@nome", novoProduto.Nome);
                    cmd.Parameters.AddWithValue("@preco", novoProduto.Preco);
                    cmd.Parameters.AddWithValue("@quantidade", novoProduto.Quantidade);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
