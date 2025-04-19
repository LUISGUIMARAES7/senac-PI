namespace SistemaPI
{
    partial class TelaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelErro = new Label();
            groupBox3 = new GroupBox();
            textBoxTotal = new TextBox();
            labelTotal = new Label();
            numericQuantidade = new NumericUpDown();
            labelProduto = new Label();
            labelQuantidade = new Label();
            labelCliente = new Label();
            buttonCriar = new Button();
            buttonRemover = new Button();
            buttonEditar = new Button();
            dataGridView1 = new DataGridView();
            labelCadastrarPedido = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            textBoxCliente = new TextBox();
            textBoxProduto = new TextBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(17, 417);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxProduto);
            groupBox3.Controls.Add(textBoxCliente);
            groupBox3.Controls.Add(textBoxTotal);
            groupBox3.Controls.Add(labelTotal);
            groupBox3.Controls.Add(numericQuantidade);
            groupBox3.Controls.Add(labelProduto);
            groupBox3.Controls.Add(labelQuantidade);
            groupBox3.Controls.Add(labelCliente);
            groupBox3.Location = new Point(27, 78);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(645, 107);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(464, 74);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(100, 23);
            textBoxTotal.TabIndex = 22;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(426, 81);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "Total";
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(121, 72);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 23);
            numericQuantidade.TabIndex = 17;
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(54, 51);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 16;
            labelProduto.Text = "Produto";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(35, 77);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 12;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(54, 24);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 10;
            labelCliente.Text = "Cliente";
            // 
            // buttonCriar
            // 
            buttonCriar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCriar.Location = new Point(703, 92);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 6;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Location = new Point(703, 159);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 8;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(703, 125);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 7;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 191);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(751, 235);
            dataGridView1.TabIndex = 18;
            // 
            // labelCadastrarPedido
            // 
            labelCadastrarPedido.Anchor = AnchorStyles.Top;
            labelCadastrarPedido.AutoSize = true;
            labelCadastrarPedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastrarPedido.ForeColor = Color.White;
            labelCadastrarPedido.Location = new Point(301, 7);
            labelCadastrarPedido.Name = "labelCadastrarPedido";
            labelCadastrarPedido.Size = new Size(198, 25);
            labelCadastrarPedido.TabIndex = 21;
            labelCadastrarPedido.Text = "CADASTRAR PEDIDO";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(labelCadastrarPedido);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Font = new Font("Segoe UI", 9F);
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            pedidosToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(62, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Location = new Point(121, 18);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(443, 23);
            textBoxCliente.TabIndex = 0;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(121, 45);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(443, 23);
            textBoxProduto.TabIndex = 1;
            // 
            // TelaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(labelErro);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCriar);
            Controls.Add(buttonRemover);
            Name = "TelaPedido";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private GroupBox groupBox3;
        private Button buttonCriar;
        private Label labelQuantidade;
        private Button buttonRemover;
        private Button buttonEditar;
        private Label labelCliente;
        private DataGridView dataGridView1;
        private NumericUpDown numericQuantidade;
        private Label labelProduto;
        private TextBox textBoxTotal;
        private Label labelTotal;
        private Label labelCadastrarPedido;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private TextBox textBoxProduto;
        private TextBox textBoxCliente;
    }
}