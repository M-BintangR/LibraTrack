namespace LibraTrack
{
    partial class PenggunaPanel
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
            btnLogout = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label2 = new Label();
            btnBuku = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnKembalikanBuku = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnBuku).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnKembalikanBuku).BeginInit();
            SuspendLayout();
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
            btnLogout.Location = new Point(229, 105);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(128, 51);
            btnLogout.TabIndex = 36;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(19, 146, 167);
            label5.Location = new Point(48, 192);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(248, 25);
            label5.TabIndex = 35;
            label5.Text = "Anda Ingin Apa Sekarang?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 366);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 34;
            label2.Text = "Pinjam Buku";
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
            btnBuku.Location = new Point(54, 249);
            btnBuku.Name = "btnBuku";
            btnBuku.Size = new Size(99, 99);
            btnBuku.TabIndex = 33;
            btnBuku.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(229, 67);
            label4.Name = "label4";
            label4.Size = new Size(151, 19);
            label4.TabIndex = 30;
            label4.Text = "Mau Pinjam Buku Apa?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 28);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 29;
            label3.Text = "Selamat Datang 👋";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(54, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 128);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 366);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 38;
            label1.Text = "Kembalikan Buku";
            // 
            // btnKembalikanBuku
            // 
            btnKembalikanBuku.BackColor = Color.White;
            btnKembalikanBuku.Cursor = Cursors.Hand;
            btnKembalikanBuku.ForeColor = Color.FromArgb(15, 83, 122);
            btnKembalikanBuku.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnKembalikanBuku.IconColor = Color.FromArgb(15, 83, 122);
            btnKembalikanBuku.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnKembalikanBuku.IconSize = 99;
            btnKembalikanBuku.Location = new Point(211, 251);
            btnKembalikanBuku.Name = "btnKembalikanBuku";
            btnKembalikanBuku.Size = new Size(99, 99);
            btnKembalikanBuku.TabIndex = 37;
            btnKembalikanBuku.TabStop = false;
            // 
            // PenggunaPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(label1);
            Controls.Add(btnKembalikanBuku);
            Controls.Add(btnLogout);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btnBuku);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PenggunaPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PenggunaPanel";
            ((System.ComponentModel.ISupportInitialize)btnBuku).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnKembalikanBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLogout;
        private Label label5;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox btnBuku;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox btnKembalikanBuku;
    }
}