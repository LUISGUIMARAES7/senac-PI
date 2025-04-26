using SistemaPI.dominio;
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
        public TelaPedido()
        {
            InitializeComponent();

            ListarPedido();
            ListarTodosClientes();
            ListarTodosProdutos();

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

            foreach (var cliente in clientes)
            {
                comboBoxCliente.Items.Add(cliente.Nome);
            }
        }

        public void ListarTodosProdutos()
        {
            var produtos = Pedido.ListarTodosProdutos();

            foreach (var produto in produtos)
            {
                comboBoxProduto.Items.Add(produto.Nome);
            }
        }

        private bool CriarPedido()
        {
            try
            {
                Pedido.Total = Convert.ToDecimal(maskedTextBoxTotal.Text);

            }
            catch { }
            Pedido.Cliente = (Cliente)comboBoxCliente.SelectedValue;
            Pedido.Produto = (Produto)comboBoxProduto.SelectedValue;
            Pedido.Quantidade = (int)numericQuantidade.Value;

            string validacaoProduto = Pedido.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoProduto))
            {
                labelErro.Text = validacaoProduto;
                return false;
            }

            return true;
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (!CriarPedido())
            {
                return;
            }

            if (dataGridViewPedidos.SelectedRows.Count == 0 || dataGridViewPedidos.SelectedRows[0].Index < 0)
            {
                Pedido.InserirPedido();
                ListarPedido();
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
            buttonAdicionar.Text = "Adicionar";
        }

        public void LimparForm()
        {
            comboBoxCliente.SelectedText = "";
            comboBoxProduto.SelectedText = "";
            numericQuantidade.Value = 0;
            labelErro.Text = string.Empty;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPedidos.SelectedRows.Count == 0 || dataGridViewPedidos.SelectedRows[0].Index < 0)
            {
                return;
            }

            buttonAdicionar.Text = "Salvar";

            int id = (int)dataGridViewPedidos.SelectedRows[0].Cells[0].Value;

            var pedido = Pedido.BuscarPedidoPorId(id);

            if (pedido == null)
            {
                return;
            }
            Pedido = pedido;

            comboBoxCliente.SelectedValue = pedido.Cliente.ToString();
            comboBoxProduto.Text = pedido.Produto.ToString();
            numericQuantidade.Text = pedido.Quantidade.ToString();
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
    }
}
