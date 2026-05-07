namespace AgenciaViagensKR
{
    partial class CadastrarCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCli));
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 156);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += this.label1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(223, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(162, 231);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Data Nasc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(162, 268);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "E-mail:";
            label4.Click += this.label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label6.Location = new Point(162, 345);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 6;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label7.Location = new Point(162, 383);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 7;
            label7.Text = "Histórico:";
            label7.Click += this.label7_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(223, 194);
            maskedTextBox1.Mask = "999.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(162, 23);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Location = new Point(254, 231);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(131, 23);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(223, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(224, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Location = new Point(239, 345);
            maskedTextBox3.Mask = "(99) 00000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(146, 23);
            maskedTextBox3.TabIndex = 12;
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(239, 384);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(167, 430);
            button1.Name = "button1";
            button1.Size = new Size(218, 35);
            button1.TabIndex = 14;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-9, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 378);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(162, 194);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 17;
            label2.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(162, 306);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 18;
            label5.Text = "Senha:";
            label5.Click += this.label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(58, 43);
            label8.Name = "label8";
            label8.Size = new Size(340, 37);
            label8.TabIndex = 19;
            label8.Text = "Cadastrar um Cliente";
            label8.Click += label8_Click;
            // 
            // CadastrarCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(554, 492);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarCli";
            Text = "LBP Airlines (Cliente - Cadastrar)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox4;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label label8;
    }
}