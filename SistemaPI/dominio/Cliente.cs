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
                return "O campo nome é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Telefone) || Telefone.Length != 11)
            {
                return "O campo Telefone é obrigatório";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "O campo Email é obrigatório";
            }

            if (!Email.Contains('@') && !Email.Contains('.'))
            {
                return "O campo Email deve ser um email válido";
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
