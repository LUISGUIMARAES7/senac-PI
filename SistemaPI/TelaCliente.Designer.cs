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
            textBoxTelefone = new TextBox();
            buttonCriar = new Button();
            labelTelefone = new Label();
            buttonRemover = new Button();
            buttonAtualizar = new Button();
            labelEmail = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            groupBox2.Controls.Add(textBoxTelefone);
            groupBox2.Controls.Add(buttonCriar);
            groupBox2.Controls.Add(labelTelefone);
            groupBox2.Controls.Add(buttonRemover);
            groupBox2.Controls.Add(buttonAtualizar);
            groupBox2.Controls.Add(labelEmail);
            groupBox2.Controls.Add(labelNome);
            groupBox2.Controls.Add(textBoxNome);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Location = new Point(32, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 123);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(119, 90);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(252, 23);
            textBoxTelefone.TabIndex = 13;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(606, 20);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 6;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(48, 98);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 12;
            labelTelefone.Text = "Telefone";
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(606, 89);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 8;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(606, 57);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 23);
            buttonAtualizar.TabIndex = 7;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(54, 61);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(54, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(119, 16);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(405, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(119, 53);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(405, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(32, 173);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(751, 235);
            dataGridView2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(306, 16);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 18;
            label4.Text = "CADASTRAR CLIENTE";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, pedidosToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(180, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // TelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(labelErro);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCliente";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Button buttonAtualizar;
        private Label labelEmail;
        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private DataGridView dataGridView2;
        private TextBox textBoxTelefone;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
    }
}