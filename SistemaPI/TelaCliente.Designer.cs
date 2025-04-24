namespace SistemaPI
{
    partial class TelaCliente
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labelErro = new Label();
            groupBox2 = new GroupBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            buttonCriar = new Button();
            buttonRemover = new Button();
            buttonEditar = new Button();
            dataGridViewClientes = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
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
            labelErro.TabIndex = 17;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(maskedTextBoxTelefone);
            groupBox2.Controls.Add(labelTelefone);
            groupBox2.Controls.Add(labelEmail);
            groupBox2.Controls.Add(labelNome);
            groupBox2.Controls.Add(textBoxNome);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Location = new Point(27, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(645, 110);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Anchor = AnchorStyles.Top;
            maskedTextBoxTelefone.Location = new Point(119, 74);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(103, 23);
            maskedTextBoxTelefone.TabIndex = 2;
            // 
            // labelTelefone
            // 
            labelTelefone.Anchor = AnchorStyles.Top;
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(54, 82);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 12;
            labelTelefone.Text = "Telefone";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top;
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(54, 53);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(54, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.Top;
            textBoxNome.Location = new Point(119, 16);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(405, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top;
            textBoxEmail.Location = new Point(119, 45);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(405, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // buttonCriar
            // 
            buttonCriar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCriar.Location = new Point(703, 90);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 3;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Location = new Point(703, 157);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEditar.Location = new Point(703, 124);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AllowUserToResizeColumns = false;
            dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(27, 191);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(751, 235);
            dataGridViewClientes.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(299, 10);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 18;
            label4.Text = "CADASTRAR CLIENTE";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, produtosToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 21;
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
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click_1;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(63, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(61, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click_1;
            // 
            // TelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(buttonCriar);
            Controls.Add(labelErro);
            Controls.Add(buttonRemover);
            Controls.Add(groupBox2);
            Controls.Add(buttonEditar);
            Controls.Add(dataGridViewClientes);
            Name = "TelaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Load += TelaCliente_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label labelErro;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private Button buttonCriar;
        private Label labelTelefone;
        private Button buttonRemover;
        private Button buttonEditar;
        private Label labelEmail;
        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private DataGridView dataGridViewClientes;
        private Label label4;
        private Panel panel1;
        private MaskedTextBox maskedTextBoxTelefone;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}