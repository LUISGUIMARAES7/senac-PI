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
    public partial class TelaCliente : Form
    {
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
    }
}
