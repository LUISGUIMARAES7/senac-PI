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
            new TelaProduto().ShowDialog();
            this.Close();
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new TelaPedido().ShowDialog();
            this.Close();
        }
    }
}
