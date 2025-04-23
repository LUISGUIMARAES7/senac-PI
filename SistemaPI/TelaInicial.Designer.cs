namespace SistemaPI
{
    partial class TelaInicial
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
            buttonCliente = new Button();
            buttonPedido = new Button();
            buttonProduto = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCliente
            // 
            buttonCliente.BackColor = Color.SkyBlue;
            buttonCliente.Location = new Point(31, 20);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(131, 38);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += button4_Click;
            // 
            // buttonPedido
            // 
            buttonPedido.BackColor = Color.SkyBlue;
            buttonPedido.Location = new Point(31, 21);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(131, 38);
            buttonPedido.TabIndex = 4;
            buttonPedido.Text = "Pedidos";
            buttonPedido.UseVisualStyleBackColor = false;
            buttonPedido.Click += button1_Click;
            // 
            // buttonProduto
            // 
            buttonProduto.BackColor = Color.SkyBlue;
            buttonProduto.Location = new Point(30, 21);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(131, 38);
            buttonProduto.TabIndex = 5;
            buttonProduto.Text = "Produtos";
            buttonProduto.UseVisualStyleBackColor = false;
            buttonProduto.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 27);
            label1.Name = "label1";
            label1.Size = new Size(606, 38);
            label1.TabIndex = 6;
            label1.Text = "SISTEMA DE CADASTRO EMPRESARIAL";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(buttonProduto);
            groupBox1.Location = new Point(22, 158);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(192, 81);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonPedido);
            groupBox2.Location = new Point(22, 45);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(192, 81);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(buttonCliente);
            groupBox3.Location = new Point(22, 274);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(193, 81);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.cadrevo;
            pictureBox1.Location = new Point(288, 113);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 370);
            panel1.TabIndex = 5;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCliente;
        private Button buttonPedido;
        private Button buttonProduto;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}