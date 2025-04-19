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
            new TelaProduto().ShowDialog();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCliente().ShowDialog();
            this.Close();
        }
    }
}
