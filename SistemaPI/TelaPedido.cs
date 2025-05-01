using MySql.Data.MySqlClient;
using SistemaPI.banco_de_dados;
using SistemaPI.dominio;
using SistemaPI.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dataGridViewPedidos.DataSource = BindingSource;
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

        //private void InicializarDataGridView()
        //{
        //    // Limpa as colunas existentes
        //    dataGridViewPedidos.Columns.Clear();

        //    // Adiciona as colunas manualmente
        //    dataGridViewPedidos.Columns.Add("pedidoId", "ID do Pedido");
        //    dataGridViewPedidos.Columns.Add("clienteNome", "Nome do Cliente");
        //    dataGridViewPedidos.Columns.Add("produtoNome", "Nome do Produto");
        //    dataGridViewPedidos.Columns.Add("total", "Total");

        //    // Certifique-se de que as colunas estão configuradas antes de adicionar dados
        //}

        //public void CarregarPedidos()
        //{
        //    var pedidos = Pedido.ListarPedidos();


        //    foreach (var pedido in pedidos)
        //    {
        //        dataGridViewPedidos.Rows.Add(
        //            pedido.Id,
        //            pedido.Cliente.Nome,
        //            pedido.Produto.Nome,
        //            pedido.Total.ToString("C")
        //        );
        //    }
        //}

        private bool CriarPedido()
        {
            try
            {
                Pedido.Total = Convert.ToDecimal(totalGeral);
            }
            catch
            {

            }

            Pedido.Cliente = (Cliente)comboBoxCliente.SelectedItem;
            Pedido.Produto = (Produto)comboBoxProduto.SelectedItem;

            string validacaoProduto = Pedido.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoProduto))
            {
                labelErro.Text = validacaoProduto;
                return false;
            }

            Pedido.DataPedido = DateTime.Now;
            Pedido.Itens = new List<(Produto, int)>(itensPedido);
            Pedido.Total = Pedido.Itens.Sum(i => i.produto.Preco * i.quantidade);

            MessageBox.Show("Pedido salvo com sucesso!");

            return true;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (!CriarPedido())
            {
                return;
            }

            if (dataGridViewPedidos.SelectedRows.Count == 0 || dataGridViewPedidos.SelectedRows[0].Index < 0)
            {
                Pedido.InserirPedido();
                ListarPedido();
                LimparForm();
                return;
            }

            int id = (int)dataGridViewPedidos.SelectedRows[0].Cells[0].Value;

            if (Pedido.BuscarPedidoPorId(id) == null)
            {
                return;
            }

            LimparForm();
            Pedido.Id = id;
            Pedido.AtualizarPedido();
            ListarPedido();
        }

        public void LimparForm()
        {
            comboBoxCliente.SelectedItem = -1;
            comboBoxProduto.SelectedItem = -1;
            numericQuantidade.Value = 0;
            labelErro.Text = string.Empty;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.SelectedRows.Count == 0 || dataGridViewPedidos.SelectedRows[0].Index < 0)
            {
                return;
            }

            buttonSalvar.Text = "Salvar";

            int id = (int)dataGridViewPedidos.SelectedRows[0].Cells[0].Value;

            var pedido = Pedido.BuscarPedidoPorId(id);

            if (pedido == null)
            {
                return;
            }
            Pedido = pedido;

            comboBoxCliente.SelectedValue = pedido.Cliente.ToString();
            comboBoxProduto.Text = pedido.Produto.ToString();
        }



        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.SelectedRows.Count == 0 || dataGridViewPedidos.SelectedRows[0].Index < 0)
            {
                return;
            }

            int id = (int)dataGridViewPedidos.SelectedRows[0].Cells[0].Value;

            Pedido.DeletarPedido(id);

            ListarPedido();
        }

        private void buttonAddProduto_Click(object sender, EventArgs e)
        {
            if (comboBoxProduto.SelectedItem == null || string.IsNullOrWhiteSpace(numericQuantidade.Text))
            {
                MessageBox.Show("Selecione um produto e informe a quantidade.");
                return;
            }

            Produto produtoSelecionado = (Produto)comboBoxProduto.SelectedItem;
            int quantidade = int.Parse(numericQuantidade.Text);
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
    }
}
