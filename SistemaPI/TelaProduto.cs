using SistemaPI.dominio;
using System.Globalization;

namespace SistemaPI
{
    public partial class TelaProduto : Form
    {
        private Produto Produto = new();
        private readonly BindingSource BindingSource = [];
        public TelaProduto()
        {
            InitializeComponent();
            BindingSource.DataSource = Produto.ListarProdutos();
            dataGridViewProdutos.DataSource = BindingSource;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();

            telaCliente.Size = this.Size;
            telaCliente.Location = this.Location;

            this.Hide();
            telaCliente.ShowDialog();
            this.Close();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPedido telaPedido = new TelaPedido();

            telaPedido.Size = this.Size;
            telaPedido.Location = this.Location;

            this.Hide();
            telaPedido.ShowDialog();
            this.Close();
        }

        private bool CriarProduto()
        {

            Produto.Nome = textBoxProduto.Text;
            Produto.Preco = decimal.Parse(textBoxPreco.Text);
            Produto.Quantidade = (int)numericQuantidade.Value;

            string validacaoProduto = Produto.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoProduto))
            {
                labelErro.Text = validacaoProduto;
                return false;
            }

            return true;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (!CriarProduto())
            {
                return;
            }

            Produto.InserirProduto();
            BindingSource.DataSource = Produto.ListarProdutos();
            dataGridViewProdutos.DataSource = BindingSource;

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true; // Cancelar o evento
            }
        }
    }
}
