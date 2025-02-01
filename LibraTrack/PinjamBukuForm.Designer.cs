namespace LibraTrack
{
    partial class PinjamBukuForm
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
            btnExit = new Button();
            btnBack = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(564, 19);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 39);
            btnExit.TabIndex = 57;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(15, 83, 122);
            btnBack.Location = new Point(679, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 39);
            btnBack.TabIndex = 56;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(198, 65);
            label4.Name = "label4";
            label4.Size = new Size(154, 19);
            label4.TabIndex = 55;
            label4.Text = "Kelola daftar pengguna.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 33);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 54;
            label3.Text = "Daftar Pengguna";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(27, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 128);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // PinjamBukuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 475);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PinjamBukuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PinjamBukuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnBack;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}