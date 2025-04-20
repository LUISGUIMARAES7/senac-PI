using SistemaPI.dominio;

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
            new TelaCliente().ShowDialog();
            this.Close();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaPedido().ShowDialog();
            this.Close();
        }

        private bool CriarProduto()
        {
            Produto.Nome = textBoxProduto.Text;
            Produto.Preco = Convert.ToInt32(textBoxPreco.Text);
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

    }
}
