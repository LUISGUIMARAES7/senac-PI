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
                        Fornecedor = (Fornecedor) reader.GetInt32("fornecedor")
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

                string query = @"
                    SELECT
                        pedido.id AS pedido_id, 
                        cliente.id AS cliente_id, 
                        cliente.nome AS cliente_nome,
                        cliente.email AS cliente_email,
                        cliente.telefone AS cliente_telefone,
                        pedido.total AS pedido_total,
                        produto.id AS produto_id,
                        produto.nome AS produto_nome,
                        produto.preco AS produto_preco,
                        produto.fornecedor AS produto_fornecedor
                    FROM pedido
                    JOIN cliente ON pedido.cliente_id = cliente.id
                    JOIN produto_pedido ON pedido.id = produto_pedido.id_pedido
                    JOIN produto ON produto_pedido.id_produto = produto.id;";

                using var cmd = new MySqlCommand(query, connection);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pedidos.Add(new Pedido
                    {
                        Id = reader.GetInt32("pedido_id"),
                        Total = reader.GetDecimal("pedido_total"),
                        Produto = new Produto
                        {
                            Id = reader.GetInt32("produto_id"),
                            Nome = reader.GetString("produto_nome"),
                            Preco = reader.GetDecimal("produto_preco"),
                            Fornecedor = (Fornecedor)reader.GetInt32("produto_fornecedor")
                        },
                        Cliente = new Cliente
                        {
                            Id = reader.GetInt32("cliente_id"),
                            Nome = reader.GetString("cliente_nome"),
                            Email = reader.GetString("cliente_email"),
                            Telefone = reader.GetString("cliente_telefone")
                        }
                    });
                }
            }

            return pedidos;
        }


        public void InserirPedido(Pedido novoPedido)
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

                //if (pedidoId == 0)
                //{
                //    // Fallback: forçar SELECT se necessário
                //    using (var cmdLastId = new MySqlCommand("SELECT LAST_INSERT_ID();", connection))
                //    {
                //        pedidoId = Convert.ToInt64(cmdLastId.ExecuteScalar());
                //    }
                //}
                Console.WriteLine($"Itens no pedido: {novoPedido.Itens?.Count}");

                foreach (var item in novoPedido.Itens)
                {
                    string sqlProdutoPedido = "INSERT INTO produto_pedido (id_produto, id_pedido, quantidade) VALUES (@id_produto, @id_pedido, @quantidade)";
                    MySqlCommand cmdProduto = new MySqlCommand(sqlProdutoPedido, connection);
                    cmdProduto.Parameters.AddWithValue("@id_produto", item.produto.Id);
                    cmdProduto.Parameters.AddWithValue("@id_pedido", pedidoId); // Use o ID recém-inserido
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

                string query = "DELETE FROM pedido WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM pedido_produto WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Pedido? BuscarPedidoPorId(int id)
        {
            string query = "SELECT pedido.id, cliente.nome as cliente, produto.nome as produto, data_pedido, total FROM pedido JOIN cliente on pedido.cliente_id = cliente.id JOIN produto on pedido.produto_id = produto.id WHERE id = @param;;";
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
                        Total = reader.GetDecimal("total"),
                        Produto = new Produto
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Preco = reader.GetDecimal("preco"),
                            Fornecedor = (Fornecedor) reader.GetInt32("fornecedor")
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

                string queryEndereco = "UPDATE produto SET nome = @nome, preco = @preco, fornecedor = @fornecedor WHERE id = @id;";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pedido.Id);
                    cmd.Parameters.AddWithValue("@cliente_id", pedido.Cliente.Id);
                    cmd.Parameters.AddWithValue("@produto_id", pedido.Produto.Id);
                    cmd.Parameters.AddWithValue("@fornecedor", pedido.Produto.Fornecedor);
                    cmd.Parameters.AddWithValue("@total", pedido.Total);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
    }
}
