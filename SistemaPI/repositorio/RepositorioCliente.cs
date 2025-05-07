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
    internal class RepositorioCliente
    {
        public List<Cliente> ListarCliente()
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

        public void InserirCliente(Cliente novoCliente)
        {
            using (var conection = Database.GetConnection())
            {
                conection.Open();

                string queryCliente = "INSERT INTO cliente (nome, email, telefone) " +
                                        "VALUES (@nome, @email, @telefone);";

                using (var cmd = new MySqlCommand(queryCliente, conection))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.Nome);
                    cmd.Parameters.AddWithValue("@email", novoCliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.Telefone);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Cliente? BuscarClientePorId(int id)
        {
            string query = "SELECT * FROM cliente WHERE id = @param;";
            return BuscarClientePorUnique(query, id.ToString());
        }

        public Cliente? BuscarClientePorEmail(string email)
        {
            string query = "SELECT * FROM cliente WHERE email = @param;";
            return BuscarClientePorUnique(query, email);
        }

        public Cliente? BuscarClientePorTelefone(string telefone)
        {
            string query = "SELECT * FROM cliente WHERE telefone = @param;";
            return BuscarClientePorUnique(query, telefone);
        }

        private Cliente? BuscarClientePorUnique(string query, string param)
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

                    return new Cliente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Telefone = reader.GetString("telefone")
                    };
                }
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "UPDATE cliente SET nome = @nome, email = @email, telefone = @telefone WHERE id = @id;";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletarCliente(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM cliente WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
