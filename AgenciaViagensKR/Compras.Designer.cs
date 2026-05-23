namespace AgenciaViagensKR
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            pictureBox1 = new PictureBox();
            Slogan = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-8, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(912, 403);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Slogan
            // 
            Slogan.AutoSize = true;
            Slogan.BackColor = Color.Transparent;
            Slogan.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            Slogan.ForeColor = Color.White;
            Slogan.ImeMode = ImeMode.NoControl;
            Slogan.Location = new Point(309, 39);
            Slogan.Name = "Slogan";
            Slogan.Size = new Size(240, 31);
            Slogan.TabIndex = 4;
            Slogan.Text = "Área de Compras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 92);
            label1.Name = "label1";
            label1.Size = new Size(224, 15);
            label1.TabIndex = 5;
            label1.Text = "Encontre os melhores pacotes de viagens";
            // 
            // button1
            // 
            button1.Location = new Point(85, 254);
            button1.Name = "button1";
            button1.Size = new Size(73, 25);
            button1.TabIndex = 6;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 291);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(15, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 125);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 157);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Rio de Janeiro";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(896, 599);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Slogan);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Compras";
            Text = "LBP Airlines (Compras)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Slogan;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}