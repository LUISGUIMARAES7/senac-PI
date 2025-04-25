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
            groupBox = new GroupBox();
            comboBoxProduto = new ComboBox();
            comboBoxCliente = new ComboBox();
            maskedTextBoxTotal = new MaskedTextBox();
            labelTotal = new Label();
            numericQuantidade = new NumericUpDown();
            labelProduto = new Label();
            labelQuantidade = new Label();
            labelCliente = new Label();
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            buttonEditar = new Button();
            dataGridViewPedidos = new DataGridView();
            labelCadastrarPedido = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).BeginInit();
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
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(comboBoxProduto);
            groupBox.Controls.Add(comboBoxCliente);
            groupBox.Controls.Add(maskedTextBoxTotal);
            groupBox.Controls.Add(labelTotal);
            groupBox.Controls.Add(numericQuantidade);
            groupBox.Controls.Add(labelProduto);
            groupBox.Controls.Add(labelQuantidade);
            groupBox.Controls.Add(labelCliente);
            groupBox.Location = new Point(27, 78);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(645, 107);
            groupBox.TabIndex = 19;
            groupBox.TabStop = false;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.Anchor = AnchorStyles.Top;
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(121, 47);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(443, 23);
            comboBoxProduto.TabIndex = 24;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.Anchor = AnchorStyles.Top;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(121, 21);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(443, 23);
            comboBoxCliente.TabIndex = 23;
            // 
            // maskedTextBoxTotal
            // 
            maskedTextBoxTotal.Anchor = AnchorStyles.Top;
            maskedTextBoxTotal.Location = new Point(464, 74);
            maskedTextBoxTotal.Mask = "$";
            maskedTextBoxTotal.Name = "maskedTextBoxTotal";
            maskedTextBoxTotal.ReadOnly = true;
            maskedTextBoxTotal.Size = new Size(100, 23);
            maskedTextBoxTotal.TabIndex = 22;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top;
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(426, 81);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "Total";
            // 
            // numericQuantidade
            // 
            numericQuantidade.Anchor = AnchorStyles.Top;
            numericQuantidade.Location = new Point(121, 72);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 23);
            numericQuantidade.TabIndex = 2;
            // 
            // labelProduto
            // 
            labelProduto.Anchor = AnchorStyles.Top;
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(54, 51);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 16;
            labelProduto.Text = "Produto";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.Top;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(35, 77);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 12;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelCliente
            // 
            labelCliente.Anchor = AnchorStyles.Top;
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(54, 24);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 10;
            labelCliente.Text = "Cliente";
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdicionar.Location = new Point(703, 92);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonCriar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Location = new Point(703, 159);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(703, 125);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.AllowUserToAddRows = false;
            dataGridViewPedidos.AllowUserToDeleteRows = false;
            dataGridViewPedidos.AllowUserToResizeColumns = false;
            dataGridViewPedidos.AllowUserToResizeRows = false;
            dataGridViewPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridViewPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(27, 191);
            dataGridViewPedidos.MultiSelect = false;
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.Size = new Size(751, 235);
            dataGridViewPedidos.TabIndex = 18;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, produtosToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
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
            // TelaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(labelErro);
            Controls.Add(groupBox);
            Controls.Add(dataGridViewPedidos);
            Controls.Add(buttonEditar);
            Controls.Add(buttonAdicionar);
            Controls.Add(buttonRemover);
            Name = "TelaPedido";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPedidos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private GroupBox groupBox;
        private Button buttonAdicionar;
        private Label labelQuantidade;
        private Button buttonRemover;
        private Button buttonEditar;
        private Label labelCliente;
        private DataGridView dataGridViewPedidos;
        private NumericUpDown numericQuantidade;
        private Label labelProduto;
        private Label labelTotal;
        private Label labelCadastrarPedido;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private MaskedTextBox maskedTextBoxTotal;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxCliente;
    }
}