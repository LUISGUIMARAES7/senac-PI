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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            label1 = new Label();
            panelLogo = new Panel();
            panel2 = new Panel();
            buttonCliente = new Button();
            groupBox1 = new GroupBox();
            buttonProduto = new Button();
            groupBox2 = new GroupBox();
            buttonPedido = new Button();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 27);
            label1.Name = "label1";
            label1.Size = new Size(388, 38);
            label1.TabIndex = 6;
            label1.Text = "SISTEMA DE CADASTRO ";
            // 
            // panelLogo
            // 
            panelLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelLogo.BackgroundImage = Properties.Resources.Prodbase2;
            panelLogo.Location = new Point(443, 364);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(356, 85);
            panelLogo.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(12, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(54, 59);
            panel2.TabIndex = 8;
            // 
            // buttonCliente
            // 
            buttonCliente.Anchor = AnchorStyles.Top;
            buttonCliente.BackColor = Color.White;
            buttonCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCliente.Location = new Point(27, 43);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(131, 50);
            buttonCliente.TabIndex = 3;
            buttonCliente.Text = "Clientes";
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(buttonProduto);
            groupBox1.Location = new Point(36, 53);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(192, 136);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // buttonProduto
            // 
            buttonProduto.Anchor = AnchorStyles.Top;
            buttonProduto.BackColor = Color.White;
            buttonProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProduto.Location = new Point(28, 43);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(131, 50);
            buttonProduto.TabIndex = 5;
            buttonProduto.Text = "Produtos";
            buttonProduto.UseVisualStyleBackColor = false;
            buttonProduto.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonCliente);
            groupBox2.Location = new Point(282, 54);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(192, 135);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // buttonPedido
            // 
            buttonPedido.Anchor = AnchorStyles.Top;
            buttonPedido.BackColor = Color.White;
            buttonPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonPedido.Location = new Point(27, 43);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(131, 50);
            buttonPedido.TabIndex = 4;
            buttonPedido.Text = "Pedidos";
            buttonPedido.UseVisualStyleBackColor = false;
            buttonPedido.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 245);
            panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(buttonPedido);
            groupBox3.Location = new Point(535, 54);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(191, 135);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panelLogo);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panelLogo;
        private Panel panel2;
        private Button buttonCliente;
        private GroupBox groupBox1;
        private Button buttonProduto;
        private GroupBox groupBox2;
        private Button buttonPedido;
        private Panel panel1;
        private GroupBox groupBox3;
    }
}