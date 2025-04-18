namespace SistemaPI
{
    public partial class TelaProdutos : Form
    {
        public TelaProdutos()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.ShowDialog();
            this.Close();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPedidos telaPedidos = new TelaPedidos();
            telaPedidos.ShowDialog();
            this.Close();
        }
    }
}
