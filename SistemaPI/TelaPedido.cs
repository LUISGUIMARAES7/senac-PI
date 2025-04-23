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
        public TelaPedido()
        {
            InitializeComponent();
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
    }
}
