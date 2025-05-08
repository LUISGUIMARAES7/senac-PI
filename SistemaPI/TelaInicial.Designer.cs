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
            panel2 = new Panel();
            buttonPedido = new Button();
            buttonProduto = new Button();
            buttonCliente = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(12, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(93, 93);
            panel2.TabIndex = 8;
            // 
            // buttonPedido
            // 
            buttonPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPedido.BackColor = Color.Transparent;
            buttonPedido.Cursor = Cursors.Hand;
            buttonPedido.FlatAppearance.BorderColor = Color.White;
            buttonPedido.FlatAppearance.BorderSize = 0;
            buttonPedido.FlatAppearance.MouseDownBackColor = Color.White;
            buttonPedido.FlatAppearance.MouseOverBackColor = Color.White;
            buttonPedido.FlatStyle = FlatStyle.Flat;
            buttonPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonPedido.Image = (Image)resources.GetObject("buttonPedido.Image");
            buttonPedido.Location = new Point(560, 131);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(242, 338);
            buttonPedido.TabIndex = 4;
            buttonPedido.UseVisualStyleBackColor = false;
            buttonPedido.Click += button1_Click;
            // 
            // buttonProduto
            // 
            buttonProduto.Anchor = AnchorStyles.Top;
            buttonProduto.BackColor = Color.Transparent;
            buttonProduto.Cursor = Cursors.Hand;
            buttonProduto.FlatAppearance.BorderColor = Color.White;
            buttonProduto.FlatAppearance.BorderSize = 0;
            buttonProduto.FlatAppearance.MouseDownBackColor = Color.White;
            buttonProduto.FlatAppearance.MouseOverBackColor = Color.White;
            buttonProduto.FlatStyle = FlatStyle.Flat;
            buttonProduto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProduto.Image = (Image)resources.GetObject("buttonProduto.Image");
            buttonProduto.Location = new Point(12, 131);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(242, 338);
            buttonProduto.TabIndex = 5;
            buttonProduto.UseVisualStyleBackColor = false;
            buttonProduto.Click += button2_Click;
            // 
            // buttonCliente
            // 
            buttonCliente.BackColor = Color.Transparent;
            buttonCliente.CausesValidation = false;
            buttonCliente.Cursor = Cursors.Hand;
            buttonCliente.FlatAppearance.BorderColor = Color.White;
            buttonCliente.FlatAppearance.BorderSize = 0;
            buttonCliente.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCliente.FlatAppearance.MouseOverBackColor = Color.White;
            buttonCliente.FlatStyle = FlatStyle.Flat;
            buttonCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCliente.Image = Properties.Resources.cadcli;
            buttonCliente.Location = new Point(285, 131);
            buttonCliente.Name = "buttonCliente";
            buttonCliente.Size = new Size(242, 338);
            buttonCliente.TabIndex = 3;
            buttonCliente.TabStop = false;
            buttonCliente.UseVisualStyleBackColor = false;
            buttonCliente.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagem;
            pictureBox1.Location = new Point(92, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 84);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.White;
            ClientSize = new Size(814, 481);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPedido);
            Controls.Add(buttonCliente);
            Controls.Add(panel2);
            Controls.Add(buttonProduto);
            ForeColor = Color.Red;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button buttonPedido;
        private Button buttonProduto;
        private Button buttonCliente;
        private PictureBox pictureBox1;
    }
}