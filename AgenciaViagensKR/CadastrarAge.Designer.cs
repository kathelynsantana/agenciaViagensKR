namespace AgenciaViagensKR
{
    partial class CadastrarAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAge));
            label8 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 42);
            label8.Name = "label8";
            label8.Size = new Size(522, 37);
            label8.TabIndex = 30;
            label8.Text = "Cadastrar um Agente de Viagens";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(165, 230);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 29;
            label5.Text = "Senha:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(170, 311);
            button1.Name = "button1";
            button1.Size = new Size(218, 35);
            button1.TabIndex = 27;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(248, 267);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 23);
            textBox4.TabIndex = 26;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(227, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 25;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(226, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(165, 266);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 23;
            label7.Text = "Comissão:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(165, 192);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 22;
            label4.Text = "E-mail:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(226, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 155);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 20;
            label1.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-6, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 256);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // CadastrarAge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(554, 370);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarAge";
            Text = "LBP Airlines (Agente de Viagens - Cadastrar)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label5;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}