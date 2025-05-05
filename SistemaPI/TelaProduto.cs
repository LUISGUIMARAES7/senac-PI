using MySqlX.XDevAPI;
using SistemaPI.dominio;
using System.Globalization;

namespace SistemaPI
{
    public partial class TelaProduto : Form
    {
        private Produto Produto = new();
        private readonly BindingSource BindingSource = [];
        private List<Produto> todosProdutos = new List<Produto>();
        public TelaProduto()
        {
            InitializeComponent();
            
        }

        private void TelaProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
            ListarTodosFornecedores();
        }

        public void ListarProduto()
        {
            todosProdutos = Produto.ListarProdutos();
            BindingSource.DataSource = todosProdutos;
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
            try
            {
                Produto.Preco = Convert.ToDecimal(textBoxPreco.Text);
            }
            catch { }

            Produto.Fornecedor = (Fornecedor)comboBoxFornecedor.SelectedItem;


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
                LimparForm();
                return;
            }

            int id = (int)dataGridViewProdutos.SelectedRows[0].Cells[0].Value;

            if (Produto.BuscarProdutoPorId(id) == null)
            {
                return;
            }

            LimparForm();
            Produto.Id = id;
            Produto.AtualizarProduto();
            ListarProduto();
            buttonAdicionar.Text = "Adicionar";
        }

        

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count == 0 || dataGridViewProdutos.SelectedRows[0].Index < 0)
            {
                return;
            }

            var confirmarRemover = MessageBox.Show(
                "Tem certeza que deseja remover este produto?",
                "Confirmação de remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmarRemover != DialogResult.Yes)
            {
                return;
            }

            int id = (int)dataGridViewProdutos.SelectedRows[0].Cells[0].Value;

            Produto.DeletarCliente(id);

            ListarProduto();

        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count == 0 || dataGridViewProdutos.SelectedRows[0].Index < 0)
            {
                return;
            }

            buttonAdicionar.Text = "Salvar";

            int id = (int)dataGridViewProdutos.SelectedRows[0].Cells[0].Value;

            var produto = Produto.BuscarProdutoPorId(id);

            if (produto == null)
            {
                return;
            }
            Produto = produto;

            textBoxProduto.Text = produto.Nome.ToString();
            textBoxPreco.Text = produto.Preco.ToString();
            comboBoxFornecedor.Text = produto.Fornecedor.ToString();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();

            telaInicial.Size = this.Size;
            telaInicial.Location = this.Location;

            this.Hide();
            telaInicial.ShowDialog();
            this.Close();

        }

        private void LimparForm()
        {
            textBoxPreco.Clear();
            textBoxProduto.Clear();
            comboBoxFornecedor.SelectedIndex = -1;
            labelErro.Text = string.Empty;
        }

        private void ListarTodosFornecedores()
        {
            var fornecedores = Produto.ListarTodosFornecedores();

            comboBoxFornecedor.DataSource = fornecedores;
            comboBoxFornecedor.DisplayMember = "Nome";
            comboBoxFornecedor.ValueMember = "Id";
        }

        

        private List<Produto> FiltrarProdutos(List<Produto> produtos, string termoBusca)
        {
            return produtos.Where(p => p.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase) || p.Fornecedor.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        //private void buttonBuscar_Click(object sender, EventArgs e)
        //{
        //    string termoBusca = textBoxBuscar.Text.Trim();
        //    List<Produto> produtosFiltrados;

        //    if (string.IsNullOrEmpty(termoBusca))
        //    {
        //        // Se não digitou nada, mostra tudo
        //        produtosFiltrados = todosProdutos;
        //    }
        //    else
        //    {
        //        produtosFiltrados = FiltrarProdutos(todosProdutos, termoBusca);
        //    }

        //    AtualizarGrid(produtosFiltrados);
        //}

        private void AtualizarGrid(List<Produto> produtos)
        {
            BindingSource.DataSource = produtos;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string termoBusca = textBoxBuscar.Text.Trim();
            var produtosFiltrados = FiltrarProdutos(todosProdutos, termoBusca);
            AtualizarGrid(produtosFiltrados);
        }
    }
}
