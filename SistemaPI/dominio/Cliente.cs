using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPI.repositorio;

namespace SistemaPI.dominio
{
    internal class Cliente
    {
        private readonly RepositorioCliente Repositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public List<Cliente> ListarCliente()
        {
            return Repositorio.ListarCliente();
        }

        public void InserirCliente()
        {
            Repositorio.InserirCliente(this);
        }

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "O campo 'nome' é obrigatório.";
            }

            if (!Nome.Contains(" ") || Nome.Trim().Split(" ").Length < 2)
            {
                return "O campo 'nome' está incompleto.";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "O campo 'email' é obrigatório.";
            }

            if (!Email.Contains("@") || !Email.Contains(".com"))
            {
                return "O campo 'email' está incompleto.";
            }

            if (string.IsNullOrWhiteSpace(Telefone))
            {
                return "O campo 'telefone' é obrigatório.";
            }

            if (Telefone[2] != '9' || Telefone.Length != 11)
            {
                return "O campo 'telefone' está incompleto.";
            }

            var clienteExistente = Repositorio.BuscarClientePorEmail(Email);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse email.";
            }

            clienteExistente = Repositorio.BuscarClientePorTelefone(Telefone);
            if (clienteExistente != null && clienteExistente?.Id != Id)
            {
                return "Já existe um cliente com esse telefone.";
            }

            return "";
        }

        public Cliente? BuscarClientePorId(int id)
        {
            return Repositorio.BuscarClientePorId(id);
        }

        public void AtualizarCliente()
        {
            Repositorio.EditarCliente(this);
        }

        public void DeletarCliente(int id)
        {
            Repositorio.DeletarCliente(id);
        }
    }
}
