using SistemaPI.dominio;

namespace SistemaPI
{
    public partial class TelaPedido : Form
    {
        private Pedido Pedido = new();
        private readonly BindingSource BindingSource = [];

        private decimal totalGeral = 0;
        private List<(Produto produto, int quantidade)> itensPedido = new();
        public TelaPedido()
        {
            InitializeComponent();

        }

        private void TelaPedido_Load(object sender, EventArgs e)
        {
            ListarTodosClientes();
            ListarTodosProdutos();
            ListarPedido();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaProduto telaProduto = new TelaProduto();

            telaProduto.Size = this.Size;
            telaProduto.Location = this.Location;

            this.Hide();
            telaProduto.ShowDialog();
            this.Close();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();

            telaInicial.Size = this.Size;
            telaInicial.Location = this.Location;

            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }

        public void ListarPedido()
        {
            BindingSource.DataSource = Pedido.ListarPedidos();
            dgvPedidos.DataSource = BindingSource;
        }

        public void ListarTodosClientes()
        {
            var clientes = Pedido.ListarTodosClientes();

            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.ValueMember = "Id";

            foreach (var cliente in clientes)
            {
                comboBoxCliente.Items.Add(cliente);
            }
        }

        public void ListarTodosProdutos()
        {
            var produtos = Pedido.ListarTodosProdutos();

            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.ValueMember = "Id";

            foreach (var produto in produtos)
            {
                comboBoxProduto.Items.Add(produto);
            }
        }

        private bool CriarPedido()
        {
            Pedido.DataPedido = DateTime.Now;

            Pedido.Cliente = (Cliente)comboBoxCliente.SelectedItem;
            if (Pedido.Cliente == null)
            {
                MessageBox.Show("Selecione um cliente.");
                return false;
            }

            Pedido.Itens = new List<(Produto, int)>(itensPedido);
            if (Pedido.Itens == null || Pedido.Itens.Count <= 0)
            {
                MessageBox.Show("Selecione um produto.");
                return false;
            }

            Pedido.Total = Pedido.Itens.Sum(i => i.produto.Preco * i.quantidade);
            if (Pedido.Total <= 0)
            {
                MessageBox.Show("Selecione ao menos um produto.");
                return false;
            }

            return true;
        }

        private bool AtualizarPedido()
        {
            var pedido = Pedido.BuscarPedidoPorId((int)dgvPedidos.SelectedRows[0].Cells[0].Value);
            if (pedido == null)
            {
                MessageBox.Show("Selecione um pedido.");
                return false;
            }

            Pedido = pedido;

            Pedido.Itens = new List<(Produto, int)>(itensPedido);
            if (Pedido.Itens == null || Pedido.Itens.Count <= 0)
            {
                MessageBox.Show("Selecione um produto.");
                return false;
            }

            Pedido.Total = Pedido.Itens.Sum(i => i.produto.Preco * i.quantidade);
            if (Pedido.Total <= 0)
            {
                MessageBox.Show("Selecione ao menos um produto.");
                return false;
            }

            return true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var criacao = dgvPedidos.SelectedRows.Count == 0 || dgvPedidos.SelectedRows[0].Index < 0;

            if (criacao && !CriarPedido())
            {
                return;
            }

            if (!criacao && !AtualizarPedido())
            {
                return;
            }

            if (criacao)
            {
                Pedido.SalvarPedido();
            }
            else
            {
                Pedido.AtualizarPedido();
            }

            LimparForm();
            ListarPedido();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0 || dgvPedidos.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Selecione um pedido para editar.");
                return;
            }

            var pedido = Pedido.BuscarPedidoPorId((int)dgvPedidos.SelectedRows[0].Cells[0].Value);
            if (pedido == null)
            {
                MessageBox.Show("Selecione um pedido.");
                return;
            }

            Pedido = pedido;

            for (int i = 0; i < comboBoxCliente.Items.Count; i++)
            {
                if (comboBoxCliente.Items[i].ToString() == Pedido.Cliente.Nome)
                {
                    comboBoxCliente.SelectedIndex = i;
                    comboBoxCliente.Enabled = false;
                    break;
                }
            }

            foreach (var item in Pedido.Itens)
            {
                Produto produto = item.produto;
                int quantidade = item.quantidade;

                decimal valorTotalProduto = produto.Preco * quantidade;
                itensPedido.Add((produto, quantidade));

                dgvProdutosSelecionados.Rows.Add(
                    produto.Nome,
                    quantidade,
                    produto.Preco.ToString("C"),
                    valorTotalProduto.ToString("C"));

                totalGeral += valorTotalProduto;
            }

            textBoxTotal.Text = totalGeral.ToString("C");

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0 || dgvPedidos.SelectedRows[0].Index < 0)
            {
                return;
            }

            var confirmarRemover = MessageBox.Show(
                "Tem certeza que deseja remover este pedido?",
                "Confirmação de remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmarRemover != DialogResult.Yes)
            {
                return;
            }

            int id = (int)dgvPedidos.SelectedRows[0].Cells[0].Value;

            Pedido.DeletarPedido(id);

            LimparForm();
            ListarPedido();
        }

        private void buttonAddProduto_Click(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedItem == null || numericQuantidade.Value <= 0)
            {
                MessageBox.Show("Selecione um produto e informe a quantidade.");
                return;
            }

            Produto produtoSelecionado = (Produto)comboBoxProduto.SelectedItem;
            int quantidade = (int)numericQuantidade.Value;

            decimal valorTotalProduto = produtoSelecionado.Preco * quantidade;

            itensPedido.Add((produtoSelecionado, quantidade));

            dgvProdutosSelecionados.Rows.Add(
                produtoSelecionado.Nome,
                quantidade,
                produtoSelecionado.Preco.ToString("C"),
                valorTotalProduto.ToString("C"));

            totalGeral += valorTotalProduto;
            textBoxTotal.Text = totalGeral.ToString("C");
        }

        private void buttonRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutosSelecionados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }
            // Índice da linha selecionada
            int rowIndex = dgvProdutosSelecionados.CurrentRow.Index;
            if (rowIndex >= 0 && rowIndex < itensPedido.Count)
            {
                // Recupera o item correspondente
                var item = itensPedido[rowIndex];
                decimal valorItem = item.produto.Preco * item.quantidade;
                // Subtrai do total
                totalGeral -= valorItem;
                textBoxTotal.Text = totalGeral.ToString("C");
                // Remove da lista e do DataGridView
                itensPedido.RemoveAt(rowIndex);
                dgvProdutosSelecionados.Rows.RemoveAt(rowIndex);
            }
        }

        private void LimparForm()
        {

            dgvProdutosSelecionados.Rows.Clear();
            itensPedido.Clear();
            totalGeral = 0;
            textBoxTotal.Text = totalGeral.ToString("C");
            comboBoxCliente.SelectedIndex = -1;
            comboBoxProduto.SelectedIndex = -1;
            numericQuantidade.Value = 1;
            labelErro.Text = "";

            comboBoxCliente.Enabled = true;

            Pedido = new();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimparForm();
            ListarPedido();
        }
    }
}
