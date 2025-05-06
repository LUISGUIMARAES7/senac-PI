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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaPI
{
    public partial class TelaCliente : Form
    {
        private Cliente Cliente = new();
        private readonly BindingSource BindingSource = [];
        private List<Cliente> todosClientes = new List<Cliente>();
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaProduto telaProduto = new TelaProduto();

            telaProduto.StartPosition = FormStartPosition.Manual;
            telaProduto.Size = this.Size;
            telaProduto.Location = this.Location;
            this.Hide();
            telaProduto.ShowDialog();
            this.Close();
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaPedido telaPedido = new TelaPedido();

            telaPedido.Size = this.Size;
            telaPedido.Location = this.Location;

            this.Hide();
            telaPedido.ShowDialog();
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

        private void TelaCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private bool CriarCliente()
        {
            Cliente.Nome = textBoxNome.Text;
            try
            {
                Cliente.Telefone = maskedTextBoxTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            }
            catch { }

            Cliente.Email = textBoxEmail.Text;

            string validacaoProduto = Cliente.Validar();
            if (!string.IsNullOrWhiteSpace(validacaoProduto))
            {
                labelErro.Text = validacaoProduto;
                return false;
            }

            return true;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (!CriarCliente())
            {
                return;
            }

            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                Cliente.InserirCliente();
                ListarCliente();
                LimparForm();
                return;
            }

            int id = (int)dataGridViewClientes.SelectedRows[0].Cells[0].Value;

            if (Cliente.BuscarClientePorId(id) == null)
            {
                return;
            }

            LimparForm();
            Cliente.Id = id;
            Cliente.AtualizarCliente();
            ListarCliente();
            buttonAdicionar.Text = "Adicionar";
        }

        public void ListarCliente()
        {
            todosClientes = Cliente.ListarCliente();
            BindingSource.DataSource = todosClientes;
            dataGridViewClientes.DataSource = BindingSource;

            //BindingSource.DataSource = Cliente.ListarCliente();
            //dataGridViewClientes.DataSource = BindingSource;
        }

        private void LimparForm()
        {
            textBoxNome.Clear();
            textBoxEmail.Clear();
            maskedTextBoxTelefone.Clear();
            textBoxBuscar.Clear();
            labelErro.Text = string.Empty;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
            {
                return;
            }

            buttonAdicionar.Text = "Salvar";

            int id = (int)dataGridViewClientes.SelectedRows[0].Cells[0].Value;

            var cliente = Cliente.BuscarClientePorId(id);

            if (cliente == null)
            {
                return;
            }
            Cliente = cliente;

            textBoxNome.Text = cliente.Nome.ToString();
            textBoxEmail.Text = cliente.Email.ToString();
            maskedTextBoxTelefone.Text = cliente.Telefone.ToString();

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0 || dataGridViewClientes.SelectedRows[0].Index < 0)
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

            int id = (int)dataGridViewClientes.SelectedRows[0].Cells[0].Value;

            Cliente.DeletarCliente(id);
            LimparForm();
            ListarCliente();
        }

        private List<Cliente> FiltrarClientes(List<Cliente> clientes, string termoBusca)
        {
            return clientes.Where(p => p.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase) || 
            p.Telefone.Contains(termoBusca, StringComparison.OrdinalIgnoreCase) || 
            p.Email.Contains(termoBusca, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        private void AtualizarGrid(List<Cliente> clientes)
        {
            BindingSource.DataSource = clientes;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string termoBusca = textBoxBuscar.Text.Trim();
            var produtosFiltrados = FiltrarClientes(todosClientes, termoBusca);
            AtualizarGrid(produtosFiltrados);
        }
    }
}
