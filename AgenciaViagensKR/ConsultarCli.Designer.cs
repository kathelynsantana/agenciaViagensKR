namespace AgenciaViagensKR
{
    partial class ConsultarCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCli));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Slogan = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-6, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 424);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(530, 373);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Slogan
            // 
            Slogan.AutoSize = true;
            Slogan.BackColor = Color.Transparent;
            Slogan.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            Slogan.ForeColor = Color.White;
            Slogan.Location = new Point(68, 42);
            Slogan.Name = "Slogan";
            Slogan.Size = new Size(336, 37);
            Slogan.TabIndex = 39;
            Slogan.Text = "Consultar um Cliente";
            // 
            // ConsultarCli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(554, 535);
            Controls.Add(Slogan);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultarCli";
            Text = " LBP Airlines (Cliente - Consultar)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label Slogan;
    }
}