namespace SistemaPI
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
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
    }
}
