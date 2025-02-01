namespace LibraTrack
{
    partial class PanelAdmin
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnPengguna = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            label2 = new Label();
            btnBuku = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            btnLogout = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPengguna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuku).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(23, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 128);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(198, 65);
            label4.Name = "label4";
            label4.Size = new Size(282, 19);
            label4.TabIndex = 21;
            label4.Text = "Sekarang anda dapat mengelola data admin!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 30);
            label3.Name = "label3";
            label3.Size = new Size(222, 25);
            label3.TabIndex = 20;
            label3.Text = "Selamat Datang Admin!";
            // 
            // btnPengguna
            // 
            btnPengguna.BackColor = Color.White;
            btnPengguna.ForeColor = Color.FromArgb(15, 83, 122);
            btnPengguna.IconChar = FontAwesome.Sharp.IconChar.User;
            btnPengguna.IconColor = Color.FromArgb(15, 83, 122);
            btnPengguna.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnPengguna.IconSize = 99;
            btnPengguna.Location = new Point(115, 281);
            btnPengguna.Name = "btnPengguna";
            btnPengguna.Size = new Size(99, 99);
            btnPengguna.TabIndex = 22;
            btnPengguna.TabStop = false;
            btnPengguna.Click += btnPengguna_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 403);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 23;
            label1.Text = "Tambah Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 403);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 25;
            label2.Text = "Tambah Buku";
            // 
            // btnBuku
            // 
            btnBuku.BackColor = Color.White;
            btnBuku.ForeColor = Color.FromArgb(15, 83, 122);
            btnBuku.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnBuku.IconColor = Color.FromArgb(15, 83, 122);
            btnBuku.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBuku.IconSize = 99;
            btnBuku.Location = new Point(303, 281);
            btnBuku.Name = "btnBuku";
            btnBuku.Size = new Size(99, 99);
            btnBuku.TabIndex = 24;
            btnBuku.TabStop = false;
            btnBuku.Click += btnBuku_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(19, 146, 167);
            label5.Location = new Point(23, 189);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(248, 25);
            label5.TabIndex = 26;
            label5.Text = "Sekarang Mau Kelola Apa?";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(201, 98);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(128, 51);
            btnLogout.TabIndex = 27;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(530, 501);
            Controls.Add(btnLogout);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnBuku);
            Controls.Add(label1);
            Controls.Add(btnPengguna);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanelAdmin";
            Text = "PanelAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPengguna).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox btnPengguna;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox btnBuku;
        private Label label5;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}