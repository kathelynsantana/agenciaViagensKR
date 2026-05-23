namespace AgenciaViagensKR
{
    partial class ExcluirAge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirAge));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Slogan = new Label();
            label5 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(170, 336);
            label4.Name = "label4";
            label4.Size = new Size(203, 19);
            label4.TabIndex = 25;
            label4.Text = "Se sim, clique no botão abaixo.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.Location = new Point(134, 305);
            label3.Name = "label3";
            label3.Size = new Size(281, 25);
            label3.TabIndex = 24;
            label3.Text = "Tem certeza que deseja excluir?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(163, 243);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 22;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 169);
            label1.Name = "label1";
            label1.Size = new Size(347, 25);
            label1.TabIndex = 21;
            label1.Text = "Informe o código do agente de viagens";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.ForeColor = Color.Black;
            maskedTextBox1.Location = new Point(233, 244);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 23);
            maskedTextBox1.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(163, 373);
            button1.Name = "button1";
            button1.Size = new Size(218, 35);
            button1.TabIndex = 19;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-6, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 361);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Slogan
            // 
            Slogan.AutoSize = true;
            Slogan.BackColor = Color.Transparent;
            Slogan.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Slogan.ForeColor = Color.White;
            Slogan.Location = new Point(53, 47);
            Slogan.Name = "Slogan";
            Slogan.Size = new Size(361, 29);
            Slogan.TabIndex = 26;
            Slogan.Text = "Excluir um Agente de Viagens";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.Location = new Point(188, 194);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 27;
            label5.Text = "que deseja excluir.";
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(523, -1);
            button6.Name = "button6";
            button6.Size = new Size(33, 35);
            button6.TabIndex = 49;
            button6.Text = "↩";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ExcluirAge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 475);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(Slogan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExcluirAge";
            Text = " LBP Airlines (Agente de Viagens - Excluir)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label Slogan;
        private Label label5;
        private Button button6;
    }
}