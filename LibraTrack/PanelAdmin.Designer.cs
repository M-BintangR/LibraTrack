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
            label6 = new Label();
            btnPinjaman = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            label11 = new Label();
            totalPinjamanSelesai = new Label();
            label16 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            totalPinjaman = new Label();
            label14 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            totalBuku = new Label();
            label13 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label10 = new Label();
            totalPengguna = new Label();
            label9 = new Label();
            totalAdmin = new Label();
            label8 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPengguna).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBuku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPinjaman).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            label4.Size = new Size(237, 19);
            label4.TabIndex = 21;
            label4.Text = "Ringkasan aplikasi anda berada disini.";
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
            btnPengguna.Cursor = Cursors.Hand;
            btnPengguna.ForeColor = Color.FromArgb(15, 83, 122);
            btnPengguna.IconChar = FontAwesome.Sharp.IconChar.User;
            btnPengguna.IconColor = Color.FromArgb(15, 83, 122);
            btnPengguna.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnPengguna.IconSize = 99;
            btnPengguna.Location = new Point(56, 271);
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
            label1.Location = new Point(32, 393);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 23;
            label1.Text = "Tambah Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 393);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 25;
            label2.Text = "Tambah Buku";
            // 
            // btnBuku
            // 
            btnBuku.BackColor = Color.White;
            btnBuku.Cursor = Cursors.Hand;
            btnBuku.ForeColor = Color.FromArgb(15, 83, 122);
            btnBuku.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnBuku.IconColor = Color.FromArgb(15, 83, 122);
            btnBuku.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBuku.IconSize = 99;
            btnBuku.Location = new Point(244, 271);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(407, 394);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 36;
            label6.Text = "Daftar Pinjaman";
            // 
            // btnPinjaman
            // 
            btnPinjaman.BackColor = Color.White;
            btnPinjaman.Cursor = Cursors.Hand;
            btnPinjaman.ForeColor = Color.FromArgb(15, 83, 122);
            btnPinjaman.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnPinjaman.IconColor = Color.FromArgb(15, 83, 122);
            btnPinjaman.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnPinjaman.IconSize = 99;
            btnPinjaman.Location = new Point(423, 271);
            btnPinjaman.Name = "btnPinjaman";
            btnPinjaman.Size = new Size(99, 99);
            btnPinjaman.TabIndex = 35;
            btnPinjaman.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(totalPinjamanSelesai);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(iconPictureBox4);
            panel1.Controls.Add(totalPinjaman);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Controls.Add(totalBuku);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(totalPengguna);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(totalAdmin);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(600, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 422);
            panel1.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F);
            label11.ForeColor = Color.FromArgb(19, 146, 167);
            label11.Location = new Point(17, 55);
            label11.Name = "label11";
            label11.Size = new Size(137, 13);
            label11.TabIndex = 38;
            label11.Text = "Lihat rigkasan data anda!";
            // 
            // totalPinjamanSelesai
            // 
            totalPinjamanSelesai.AutoSize = true;
            totalPinjamanSelesai.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPinjamanSelesai.Location = new Point(85, 357);
            totalPinjamanSelesai.Name = "totalPinjamanSelesai";
            totalPinjamanSelesai.Size = new Size(17, 20);
            totalPinjamanSelesai.TabIndex = 50;
            totalPinjamanSelesai.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(81, 331);
            label16.Name = "label16";
            label16.Size = new Size(125, 15);
            label16.TabIndex = 49;
            label16.Text = "Total Pinjaman Selesai";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.White;
            iconPictureBox4.ForeColor = Color.FromArgb(15, 83, 122);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            iconPictureBox4.IconColor = Color.FromArgb(15, 83, 122);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox4.IconSize = 51;
            iconPictureBox4.Location = new Point(17, 331);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(51, 51);
            iconPictureBox4.TabIndex = 48;
            iconPictureBox4.TabStop = false;
            // 
            // totalPinjaman
            // 
            totalPinjaman.AutoSize = true;
            totalPinjaman.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPinjaman.Location = new Point(85, 279);
            totalPinjaman.Name = "totalPinjaman";
            totalPinjaman.Size = new Size(17, 20);
            totalPinjaman.TabIndex = 47;
            totalPinjaman.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(81, 253);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 46;
            label14.Text = "Total Pinjaman";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = Color.FromArgb(15, 83, 122);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            iconPictureBox3.IconColor = Color.FromArgb(15, 83, 122);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox3.IconSize = 51;
            iconPictureBox3.Location = new Point(17, 253);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(51, 51);
            iconPictureBox3.TabIndex = 38;
            iconPictureBox3.TabStop = false;
            // 
            // totalBuku
            // 
            totalBuku.AutoSize = true;
            totalBuku.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalBuku.Location = new Point(85, 204);
            totalBuku.Name = "totalBuku";
            totalBuku.Size = new Size(17, 20);
            totalBuku.TabIndex = 45;
            totalBuku.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(81, 178);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 44;
            label13.Text = "Total Buku";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(15, 83, 122);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            iconPictureBox2.IconColor = Color.FromArgb(15, 83, 122);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconPictureBox2.IconSize = 51;
            iconPictureBox2.Location = new Point(17, 178);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(51, 51);
            iconPictureBox2.TabIndex = 38;
            iconPictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(19, 146, 167);
            label10.Location = new Point(207, 133);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 43;
            label10.Text = "Pengguna";
            // 
            // totalPengguna
            // 
            totalPengguna.AutoSize = true;
            totalPengguna.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPengguna.Location = new Point(172, 130);
            totalPengguna.Name = "totalPengguna";
            totalPengguna.Size = new Size(17, 20);
            totalPengguna.TabIndex = 42;
            totalPengguna.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(130, 202, 24);
            label9.Location = new Point(118, 133);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 41;
            label9.Text = "Admin";
            // 
            // totalAdmin
            // 
            totalAdmin.AutoSize = true;
            totalAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalAdmin.Location = new Point(81, 130);
            totalAdmin.Name = "totalAdmin";
            totalAdmin.Size = new Size(17, 20);
            totalAdmin.TabIndex = 40;
            totalAdmin.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(77, 104);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 39;
            label8.Text = "Total Pengguna";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(15, 83, 122);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.FromArgb(15, 83, 122);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconPictureBox1.IconSize = 51;
            iconPictureBox1.Location = new Point(17, 100);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(51, 51);
            iconPictureBox1.TabIndex = 38;
            iconPictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 34);
            label7.Name = "label7";
            label7.Size = new Size(132, 19);
            label7.TabIndex = 38;
            label7.Text = "Jumlah data anda!";
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(919, 501);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(btnPinjaman);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPengguna).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBuku).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPinjaman).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
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
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox btnPinjaman;
        private Panel panel1;
        private Label label10;
        private Label totalPengguna;
        private Label label9;
        private Label totalAdmin;
        private Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label7;
        private Label label11;
        private Label totalPinjamanSelesai;
        private Label label16;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label totalPinjaman;
        private Label label14;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label totalBuku;
        private Label label13;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}