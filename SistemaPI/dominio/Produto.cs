using SistemaPI.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaPI.dominio
{
    internal class Produto
    {
        private readonly Repositorio Repositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Quantidade { get; set; }

        public string Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                return "O campo Nome é obrigatório";
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
    }
}
