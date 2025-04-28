using MySql.Data.MySqlClient;
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

        public List<Pedido> ListarPedidos()
        {
            var pedidos = new List<Pedido>();

            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string query = "SELECT pedido.id, cliente.nome as cliente, produto.nome as produto,data_pedido, total FROM pedido JOIN cliente on pedido.cliente_id = cliente.id JOIN produto on pedido.produto_id = produto.id;";

                using var cmd = new MySqlCommand(query, conection);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pedidos.Add(new Pedido
                    {
                        Id = reader.GetInt32("id"),
                        Quantidade = reader.GetInt32("quantidade"),
                        Total = reader.GetDecimal("total"),
                        Produto = new Produto
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Preco = reader.GetDecimal("preco"),
                            Quantidade = reader.GetInt32("quantidade")
                        },
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Email = reader.GetString("email"),
                            Telefone = reader.GetString("telefone")
                        }
                    });
                }
            }

            return pedidos;
        }

        public void InserirPedido(Pedido novoPedido)
        {
            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string queryPedido = "INSERT INTO pedido (produto_id, quantidade, cliente_id, total)" +
                                        "VALUES(@produto_id, @quantidade, @cliente_id, @total);";

                using (var cmd = new MySqlCommand(queryPedido, conection))
                {
                    cmd.Parameters.AddWithValue("@produto_id", novoPedido.Produto.Id);
                    cmd.Parameters.AddWithValue("@cliente_id", novoPedido.Cliente.Id);
                    cmd.Parameters.AddWithValue("@quantidade", novoPedido.Quantidade);
                    cmd.Parameters.AddWithValue("@id", novoPedido.Id);
                    cmd.Parameters.AddWithValue("@total", novoPedido.Total);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void DeletarPedido(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM pedido WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Pedido? BuscarPedidoPorId(int id)
        {
            string query = "SELECT pedido.id, cliente.nome as cliente, produto.nome as produto,data_pedido, total FROM pedido JOIN cliente on pedido.cliente_id = cliente.id JOIN produto on pedido.produto_id = produto.id WHERE id = @param;;";
            return BuscarPedidoPorUnique(query, id.ToString());
        }

        private Pedido? BuscarPedidoPorUnique(string query, string param)
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

                    return new Pedido
                    {
                        Id = reader.GetInt32("id"),
                        Quantidade = reader.GetInt32("quantidade"),
                        Total = reader.GetDecimal("total"),
                        Produto = new Produto
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Preco = reader.GetDecimal("preco"),
                            Quantidade = reader.GetInt32("quantidade")
                        },
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Email = reader.GetString("email"),
                            Telefone = reader.GetString("telefone")
                        }
                    };
                }
            }
        }

        public void AtualizarPedido(Pedido pedido)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "UPDATE produto SET nome = @nome, preco = @preco, quantidade = @quantidade WHERE id = @id;";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pedido.Id);
                    cmd.Parameters.AddWithValue("@cliente_id", pedido.Cliente.Id);
                    cmd.Parameters.AddWithValue("@produto_id", pedido.Produto.Id);
                    cmd.Parameters.AddWithValue("@quantidade", pedido.Quantidade);
                    cmd.Parameters.AddWithValue("@total", pedido.Total);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
