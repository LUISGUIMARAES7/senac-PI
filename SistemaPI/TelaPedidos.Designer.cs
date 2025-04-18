namespace SistemaPI
{
    partial class TelaPedidos
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
            textBox1 = new TextBox();
            labelTotal = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            buttonCriar = new Button();
            labelPreço = new Label();
            buttonRemover = new Button();
            buttonEditar = new Button();
            labelNome = new Label();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
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
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(labelTotal);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(listBox2);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(buttonCriar);
            groupBox3.Controls.Add(labelPreço);
            groupBox3.Controls.Add(buttonRemover);
            groupBox3.Controls.Add(buttonEditar);
            groupBox3.Controls.Add(labelNome);
            groupBox3.Location = new Point(26, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(751, 123);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 88);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 22;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(428, 96);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 15);
            labelTotal.TabIndex = 21;
            labelTotal.Text = "Total";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(121, 89);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 16;
            label1.Text = "Produto";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Abacaxi", "Limão", "Maçã", "Melancia" });
            listBox2.Location = new Point(121, 57);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(443, 19);
            listBox2.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Luis", "Thiago", "Vinicius", "Felipe" });
            listBox1.Location = new Point(121, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(443, 19);
            listBox1.TabIndex = 13;
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
            // labelPreço
            // 
            labelPreço.AutoSize = true;
            labelPreço.Location = new Point(29, 97);
            labelPreço.Name = "labelPreço";
            labelPreço.Size = new Size(69, 15);
            labelPreço.TabIndex = 12;
            labelPreço.Text = "Quantidade";
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
            // buttonEditar
            // 
            buttonEditar.Location = new Point(606, 53);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 7;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(54, 24);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(44, 15);
            labelNome.TabIndex = 10;
            labelNome.Text = "Cliente";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AllowUserToResizeColumns = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(26, 173);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.Size = new Size(751, 235);
            dataGridView3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 16);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 21;
            label4.Text = "CADASTRAR PEDIDOS";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, clientesToolStripMenuItem });
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
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // TelaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(labelErro);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPedidos";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelErro;
        private GroupBox groupBox3;
        private Button buttonCriar;
        private Label labelPreço;
        private Button buttonRemover;
        private Button buttonEditar;
        private Label labelNome;
        private DataGridView dataGridView3;
        private ListBox listBox1;
        private ListBox listBox2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox textBox1;
        private Label labelTotal;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}