

namespace SistemaPI
{
    partial class TelaProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxProduto = new TextBox();
            buttonAdicionar = new Button();
            buttonEditar = new Button();
            buttonRemover = new Button();
            dataGridViewProdutos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            comboBoxFornecedor = new ComboBox();
            textBoxPreco = new TextBox();
            labelErro = new Label();
            label4 = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxProduto
            // 
            textBoxProduto.Anchor = AnchorStyles.Top;
            textBoxProduto.Location = new Point(47, 52);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(252, 23);
            textBoxProduto.TabIndex = 0;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdicionar.Location = new Point(703, 82);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(75, 23);
            buttonAdicionar.TabIndex = 3;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(703, 118);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Location = new Point(703, 153);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.AllowUserToResizeColumns = false;
            dataGridViewProdutos.AllowUserToResizeRows = false;
            dataGridViewProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(27, 218);
            dataGridViewProdutos.MultiSelect = false;
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.Size = new Size(751, 200);
            dataGridViewProdutos.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 10;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(348, 35);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(505, 36);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 12;
            label3.Text = "Fornecedor";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBoxFornecedor);
            groupBox1.Controls.Add(textBoxPreco);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxProduto);
            groupBox1.Location = new Point(27, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 101);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.Anchor = AnchorStyles.Top;
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(505, 54);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(121, 23);
            comboBoxFornecedor.TabIndex = 13;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Anchor = AnchorStyles.Top;
            textBoxPreco.Location = new Point(348, 53);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(100, 23);
            textBoxPreco.TabIndex = 1;
            textBoxPreco.KeyPress += textBoxPreco_KeyPress;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 426);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 14;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(291, 10);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 14;
            label4.Text = "CADASTRAR PRODUTO";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, produtosToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 17;
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
            produtosToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            produtosToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(69, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Anchor = AnchorStyles.Top;
            textBoxBuscar.Location = new Point(432, 189);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(252, 23);
            textBoxBuscar.TabIndex = 14;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscar.Location = new Point(703, 188);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 18;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // TelaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(panel1);
            Controls.Add(buttonAdicionar);
            Controls.Add(labelErro);
            Controls.Add(buttonRemover);
            Controls.Add(groupBox1);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += TelaProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private TextBox textBoxProduto;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button buttonAdicionar;
        private Button buttonEditar;
        private Button button2;
        private Button buttonRemover;
        private DataGridView dataGridViewProdutos;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label labelErro;
        private TextBox textBoxQuantidade;
        private Label label4;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private TextBox textBoxPreco;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ComboBox comboBoxFornecedor;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
    }
}
