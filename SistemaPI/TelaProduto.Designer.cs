﻿

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
            buttonCriar = new Button();
            buttonAtualizar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            labelErro = new Label();
            label4 = new Label();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // buttonCriar
            // 
            buttonCriar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCriar.Location = new Point(703, 82);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 3;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAtualizar.Location = new Point(703, 118);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(75, 23);
            buttonAtualizar.TabIndex = 4;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
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
            dataGridView1.TabIndex = 9;
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
            label3.Size = new Size(69, 15);
            label3.TabIndex = 12;
            label3.Text = "Quantidade";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(numericUpDown1);
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
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Top;
            maskedTextBox1.Location = new Point(348, 52);
            maskedTextBox1.Mask = "$";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top;
            numericUpDown1.Location = new Point(505, 54);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(85, 23);
            numericUpDown1.TabIndex = 2;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
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
            // TelaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(buttonCriar);
            Controls.Add(labelErro);
            Controls.Add(buttonRemover);
            Controls.Add(groupBox1);
            Controls.Add(buttonAtualizar);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button buttonCriar;
        private Button buttonAtualizar;
        private Button button2;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label labelErro;
        private TextBox textBoxQuantidade;
        private Label label4;
        private Panel panel1;
        private MaskedTextBox maskedTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
    }
}
