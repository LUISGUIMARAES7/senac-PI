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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedido));
            labelErro = new Label();
            groupBox = new GroupBox();
            dgvProdutosSelecionados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            textBoxTotal = new TextBox();
            buttonRemoverProduto = new Button();
            buttonAddProduto = new Button();
            comboBoxProduto = new ComboBox();
            comboBoxCliente = new ComboBox();
            labelTotal = new Label();
            numericQuantidade = new NumericUpDown();
            labelProduto = new Label();
            labelQuantidade = new Label();
            labelCliente = new Label();
            buttonSalvar = new Button();
            buttonRemover = new Button();
            buttonEditar = new Button();
            dgvPedidos = new DataGridView();
            labelCadastrarPedido = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            buttonCancelar = new Button();
            textBoxBuscar = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutosSelecionados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBox.Controls.Add(dgvProdutosSelecionados);
            groupBox.Controls.Add(textBoxTotal);
            groupBox.Controls.Add(buttonRemoverProduto);
            groupBox.Controls.Add(buttonAddProduto);
            groupBox.Controls.Add(comboBoxProduto);
            groupBox.Controls.Add(comboBoxCliente);
            groupBox.Controls.Add(labelTotal);
            groupBox.Controls.Add(numericQuantidade);
            groupBox.Controls.Add(labelProduto);
            groupBox.Controls.Add(labelQuantidade);
            groupBox.Controls.Add(labelCliente);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(27, 78);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(659, 221);
            groupBox.TabIndex = 19;
            groupBox.TabStop = false;
            // 
            // dgvProdutosSelecionados
            // 
            dgvProdutosSelecionados.AllowUserToAddRows = false;
            dgvProdutosSelecionados.AllowUserToDeleteRows = false;
            dgvProdutosSelecionados.AllowUserToResizeColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeRows = false;
            dgvProdutosSelecionados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvProdutosSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutosSelecionados.BackgroundColor = SystemColors.ControlLight;
            dgvProdutosSelecionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutosSelecionados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvProdutosSelecionados.Location = new Point(98, 108);
            dgvProdutosSelecionados.MultiSelect = false;
            dgvProdutosSelecionados.Name = "dgvProdutosSelecionados";
            dgvProdutosSelecionados.ReadOnly = true;
            dgvProdutosSelecionados.Size = new Size(489, 105);
            dgvProdutosSelecionados.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Produto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Preço Unit.";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Total";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Top;
            textBoxTotal.Location = new Point(294, 72);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(100, 23);
            textBoxTotal.TabIndex = 28;
            // 
            // buttonRemoverProduto
            // 
            buttonRemoverProduto.Anchor = AnchorStyles.Top;
            buttonRemoverProduto.Location = new Point(415, 72);
            buttonRemoverProduto.Name = "buttonRemoverProduto";
            buttonRemoverProduto.Size = new Size(75, 23);
            buttonRemoverProduto.TabIndex = 27;
            buttonRemoverProduto.Text = "Remover";
            buttonRemoverProduto.UseVisualStyleBackColor = true;
            buttonRemoverProduto.Click += buttonRemoverProduto_Click;
            // 
            // buttonAddProduto
            // 
            buttonAddProduto.Anchor = AnchorStyles.Top;
            buttonAddProduto.Location = new Point(496, 72);
            buttonAddProduto.Name = "buttonAddProduto";
            buttonAddProduto.Size = new Size(75, 23);
            buttonAddProduto.TabIndex = 26;
            buttonAddProduto.Text = "Adicionar";
            buttonAddProduto.UseVisualStyleBackColor = true;
            buttonAddProduto.Click += buttonAddProduto_Click;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.Anchor = AnchorStyles.Top;
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(128, 47);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(443, 23);
            comboBoxProduto.TabIndex = 24;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.Anchor = AnchorStyles.Top;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(128, 21);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(443, 23);
            comboBoxCliente.TabIndex = 23;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top;
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(256, 81);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "Total";
            // 
            // numericQuantidade
            // 
            numericQuantidade.Anchor = AnchorStyles.Top;
            numericQuantidade.Location = new Point(128, 72);
            numericQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 23);
            numericQuantidade.TabIndex = 2;
            numericQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelProduto
            // 
            labelProduto.Anchor = AnchorStyles.Top;
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(61, 51);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(50, 15);
            labelProduto.TabIndex = 16;
            labelProduto.Text = "Produto";
            // 
            // labelQuantidade
            // 
            labelQuantidade.Anchor = AnchorStyles.Top;
            labelQuantidade.AutoSize = true;
            labelQuantidade.Location = new Point(42, 77);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(69, 15);
            labelQuantidade.TabIndex = 12;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelCliente
            // 
            labelCliente.Anchor = AnchorStyles.Top;
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(61, 24);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 10;
            labelCliente.Text = "Cliente";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSalvar.Location = new Point(717, 92);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 23);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Location = new Point(717, 179);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(717, 150);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToResizeColumns = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPedidos.BackgroundColor = SystemColors.ControlLight;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(27, 334);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.Size = new Size(765, 112);
            dgvPedidos.TabIndex = 18;
            // 
            // labelCadastrarPedido
            // 
            labelCadastrarPedido.Anchor = AnchorStyles.Top;
            labelCadastrarPedido.AutoSize = true;
            labelCadastrarPedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCadastrarPedido.ForeColor = Color.White;
            labelCadastrarPedido.Location = new Point(308, 7);
            labelCadastrarPedido.Name = "labelCadastrarPedido";
            labelCadastrarPedido.Size = new Size(198, 25);
            labelCadastrarPedido.TabIndex = 21;
            labelCadastrarPedido.Text = "CADASTRAR PEDIDO";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(labelCadastrarPedido);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 45);
            panel1.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, produtosToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 24);
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
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancelar.Location = new Point(717, 121);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 25;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Anchor = AnchorStyles.Top;
            textBoxBuscar.Location = new Point(540, 305);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Buscar";
            textBoxBuscar.Size = new Size(252, 23);
            textBoxBuscar.TabIndex = 26;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logomini;
            pictureBox1.Location = new Point(702, 454);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 28);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // TelaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 481);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonCancelar);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(labelErro);
            Controls.Add(groupBox);
            Controls.Add(dgvPedidos);
            Controls.Add(buttonEditar);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonRemover);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Load += TelaPedido_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutosSelecionados).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private GroupBox groupBox;
        private Button buttonSalvar;
        private Label labelQuantidade;
        private Button buttonRemover;
        private Button buttonEditar;
        private Label labelCliente;
        private DataGridView dgvPedidos;
        private NumericUpDown numericQuantidade;
        private Label labelProduto;
        private Label labelTotal;
        private Label labelCadastrarPedido;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxCliente;
        private TextBox textBoxTotal;
        private Button buttonRemoverProduto;
        private Button buttonAddProduto;
        private DataGridView dgvProdutosSelecionados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button buttonCancelar;
        private TextBox textBoxBuscar;
        private PictureBox pictureBox1;
    }
}