using SistemaPI.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPI.dominio
{
    internal class Pedido
    {
        private readonly RepositorioPedido Repositorio = new();

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal Total { get; set; }
        public List<ProdutoPedido> ItensPedido { get; set; } = new();

        public List<(Produto produto, int quantidade)> Itens { get; set; } = new();

        public string Produtos { get; set; } = "";



        public string Validar()
        {
            //if (string.IsNullOrEmpty(Cliente.Nome))
            //{
            //    return "O campo cliente é obrigatório";
            //}

            //if (Produto.Id <= 0)
            //{
            //    return "O campo produto é obrigatório";
            //}

            //if (Quantidade < 1)
            //{
            //    return "O campo quantidade é obrigatório";
            //}

            return "";
        }

        public List<Cliente> ListarTodosClientes()
        {
            return Repositorio.ListarTodosClientes();
        }

        public List<Produto> ListarTodosProdutos()
        {
            return Repositorio.ListarTodosProdutos();
        }

        public List<Pedido> ListarPedidos()
        {
            return Repositorio.ListarPedidos();
        }


        public void SalvarPedido()
        {
            Repositorio.SalvarPedido(this);
        }

        public Pedido? BuscarPedidoPorId(int id)
        {
            return Repositorio.BuscarPedidoPorId(id);
        }

        public void DeletarPedido(int id)
        {
            Repositorio.DeletarPedido(id);
        }

        public void AtualizarPedido()
        {
            Repositorio.AtualizarPedido(this);
        }
    }
}
