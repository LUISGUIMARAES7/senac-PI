using MySqlX.XDevAPI;
using SistemaPI.repositorio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaPI.dominio
{
    internal class Produto
    {
        private readonly RepositorioProduto Repositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "O campo Produto é obrigatório";
            }

            if (Quantidade < 1)
            {
                return "O campo quantidade é obrigatório";
            }

            return string.Empty;
        }

        public List<Produto> ListarProdutos()
        {
            return Repositorio.ListarProdutos();
        }

        public void InserirProduto()
        {
            Repositorio.InserirProduto(this);
        }

        public Produto? BuscarProdutoPorId(int id)
        {
            return Repositorio.BuscarProdutoPorId(id);
        }

        public void AtualizarProduto()
        {
            Repositorio.AtualizarProduto(this);
        }
    }
}
