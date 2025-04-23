using MySqlX.XDevAPI;
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
            Produto.Preco = Convert.ToDecimal(textBoxPreco.Text);
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

            if (dataGridViewProdutos.SelectedRows.Count == 0 || dataGridViewProdutos.SelectedRows[0].Index < 0)
            {
                Produto.InserirProduto();
                ListarProduto();
                return;
            }

            int id = (int)dataGridViewProdutos.SelectedRows[0].Cells[0].Value;

            if (Produto.BuscarProdutoPorId(id) == null)
            {
                return;
            }

            Produto.Id = id;
            Produto.AtualizarProduto();
            ListarProduto();
        }

        public void ListarProduto()
        {
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count == 0 || dataGridViewProdutos.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewProdutos.SelectedRows[0].Cells[0].Value;

            var produto = Produto.BuscarProdutoPorId(id);

            if (produto == null)
            {
                return;
            }
            Produto = produto;

            textBoxProduto.Text = produto.Nome.ToString();
            textBoxPreco.Text = produto.Preco.ToString();
            numericQuantidade.Text = produto.Quantidade.ToString();
        }
    }
}
