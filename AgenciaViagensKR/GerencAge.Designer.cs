namespace AgenciaViagensKR
{
    partial class GerencAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerencAge));
            Slogan = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Slogan
            // 
            Slogan.AutoSize = true;
            Slogan.BackColor = Color.Transparent;
            Slogan.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            Slogan.ForeColor = Color.White;
            Slogan.ImeMode = ImeMode.NoControl;
            Slogan.Location = new Point(164, 47);
            Slogan.Name = "Slogan";
            Slogan.Size = new Size(330, 31);
            Slogan.TabIndex = 4;
            Slogan.Text = "Olá, Agente de Viagens!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(104, 91);
            label1.Name = "label1";
            label1.Size = new Size(493, 36);
            label1.TabIndex = 5;
            label1.Text = "Gerencie pacotes de viagens e transportes da";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(245, 131);
            label2.Name = "label2";
            label2.Size = new Size(195, 38);
            label2.TabIndex = 6;
            label2.Text = "LBP Airlines";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(-7, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(723, 442);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(36, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 359);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(24, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(585, 68);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(24, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 68);
            panel2.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(667, 0);
            button3.Name = "button3";
            button3.Size = new Size(33, 35);
            button3.TabIndex = 10;
            button3.Text = "↩";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(192, 273);
            label3.Name = "label3";
            label3.Size = new Size(312, 23);
            label3.TabIndex = 12;
            label3.Text = "Deseja acessar os pacotes de viagens?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(179, 296);
            label4.Name = "label4";
            label4.Size = new Size(332, 21);
            label4.TabIndex = 11;
            label4.Text = "Gerencie os pacotes de viagens cadastrados";
            // 
            // GerencAge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(706, 635);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Slogan);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GerencAge";
            Text = "LBP Airlines (Agente de Viagens - Gerenciamento)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Slogan;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Panel panel2;
    }
}