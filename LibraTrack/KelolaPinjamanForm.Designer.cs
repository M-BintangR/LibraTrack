namespace LibraTrack
{
    partial class KelolaPinjamanForm
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
            label2 = new Label();
            label1 = new Label();
            dtGridTable = new DataGridView();
            txtSearch = new TextBox();
            label5 = new Label();
            btnReset = new Button();
            panel1 = new Panel();
            btnKonfirmasi = new Button();
            waktuPengembalian = new Label();
            judulBuku = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            emailPeminjam = new Label();
            kotaPeminjam = new Label();
            alamatPeminjam = new Label();
            namaPeminjam = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            status = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(617, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 39);
            btnExit.TabIndex = 57;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(15, 83, 122);
            btnBack.Location = new Point(732, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 39);
            btnBack.TabIndex = 56;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(194, 66);
            label4.Name = "label4";
            label4.Size = new Size(187, 19);
            label4.TabIndex = 55;
            label4.Text = "Kelola daftar peminjam buku.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 34);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 54;
            label3.Text = "Daftar Peminjam Buku";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(23, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 128);
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(15, 83, 122);
            label2.Location = new Point(454, 197);
            label2.Name = "label2";
            label2.Size = new Size(189, 13);
            label2.TabIndex = 60;
            label2.Text = "Pincet baris untuk mengambil data.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(451, 176);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 59;
            label1.Text = "Tabel Peminjam Buku";
            // 
            // dtGridTable
            // 
            dtGridTable.BackgroundColor = Color.FromArgb(15, 83, 122);
            dtGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTable.Location = new Point(451, 274);
            dtGridTable.Name = "dtGridTable";
            dtGridTable.Size = new Size(379, 308);
            dtGridTable.TabIndex = 58;
            dtGridTable.CellContentClick += dtGridTable_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(217, 217, 217);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(510, 227);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(320, 28);
            txtSearch.TabIndex = 61;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(458, 236);
            label5.Name = "label5";
            label5.Size = new Size(36, 13);
            label5.TabIndex = 62;
            label5.Text = "Cari...";
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(15, 83, 122);
            btnReset.Location = new Point(451, 606);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(379, 39);
            btnReset.TabIndex = 63;
            btnReset.Text = "Load Data dan Bersihkan Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnKonfirmasi);
            panel1.Controls.Add(waktuPengembalian);
            panel1.Controls.Add(judulBuku);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(emailPeminjam);
            panel1.Controls.Add(kotaPeminjam);
            panel1.Controls.Add(alamatPeminjam);
            panel1.Controls.Add(namaPeminjam);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(status);
            panel1.Controls.Add(lblStatus);
            panel1.Location = new Point(23, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 460);
            panel1.TabIndex = 64;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.Lime;
            btnKonfirmasi.FlatAppearance.BorderColor = Color.Lime;
            btnKonfirmasi.FlatStyle = FlatStyle.Flat;
            btnKonfirmasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(23, 403);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(347, 39);
            btnKonfirmasi.TabIndex = 65;
            btnKonfirmasi.Text = "Setujui Pengembalian";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // waktuPengembalian
            // 
            waktuPengembalian.AutoSize = true;
            waktuPengembalian.Location = new Point(193, 357);
            waktuPengembalian.Name = "waktuPengembalian";
            waktuPengembalian.Size = new Size(44, 15);
            waktuPengembalian.TabIndex = 80;
            waktuPengembalian.Text = "label13";
            // 
            // judulBuku
            // 
            judulBuku.AutoSize = true;
            judulBuku.Location = new Point(28, 357);
            judulBuku.Name = "judulBuku";
            judulBuku.Size = new Size(44, 15);
            judulBuku.TabIndex = 79;
            judulBuku.Text = "label13";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(193, 324);
            label15.Name = "label15";
            label15.Size = new Size(121, 15);
            label15.TabIndex = 78;
            label15.Text = "Waktu Pengembalian";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(28, 324);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 77;
            label14.Text = "Judul ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(23, 289);
            label13.Name = "label13";
            label13.Size = new Size(77, 19);
            label13.TabIndex = 76;
            label13.Text = "Data Buku";
            // 
            // emailPeminjam
            // 
            emailPeminjam.AutoSize = true;
            emailPeminjam.Location = new Point(196, 243);
            emailPeminjam.Name = "emailPeminjam";
            emailPeminjam.Size = new Size(44, 15);
            emailPeminjam.TabIndex = 75;
            emailPeminjam.Text = "label13";
            // 
            // kotaPeminjam
            // 
            kotaPeminjam.AutoSize = true;
            kotaPeminjam.Location = new Point(22, 243);
            kotaPeminjam.Name = "kotaPeminjam";
            kotaPeminjam.Size = new Size(44, 15);
            kotaPeminjam.TabIndex = 74;
            kotaPeminjam.Text = "label13";
            // 
            // alamatPeminjam
            // 
            alamatPeminjam.AutoSize = true;
            alamatPeminjam.Location = new Point(196, 168);
            alamatPeminjam.Name = "alamatPeminjam";
            alamatPeminjam.Size = new Size(44, 15);
            alamatPeminjam.TabIndex = 73;
            alamatPeminjam.Text = "label13";
            // 
            // namaPeminjam
            // 
            namaPeminjam.AutoSize = true;
            namaPeminjam.Location = new Point(23, 168);
            namaPeminjam.Name = "namaPeminjam";
            namaPeminjam.Size = new Size(44, 15);
            namaPeminjam.TabIndex = 72;
            namaPeminjam.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(196, 213);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 71;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(22, 213);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 70;
            label11.Text = "Asal Kota";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(196, 141);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 69;
            label10.Text = "Alamat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 141);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 68;
            label9.Text = "Nama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(18, 107);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 67;
            label8.Text = "Data Peminjam";
            // 
            // status
            // 
            status.AutoSize = true;
            status.BackColor = Color.Red;
            status.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            status.ForeColor = Color.White;
            status.Location = new Point(18, 51);
            status.Name = "status";
            status.Padding = new Padding(5, 3, 5, 3);
            status.Size = new Size(176, 25);
            status.TabIndex = 66;
            status.Text = "BELUM DI KEMBALIKAN";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(18, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(136, 19);
            lblStatus.TabIndex = 65;
            lblStatus.Text = "Status Peminjaman";
            // 
            // KelolaPinjamanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 674);
            Controls.Add(panel1);
            Controls.Add(btnReset);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtGridTable);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KelolaPinjamanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KelolaPinjamanForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnBack;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dtGridTable;
        private TextBox txtSearch;
        private Label label5;
        private Button btnReset;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label status;
        private Label lblStatus;
        private Label waktuPengembalian;
        private Label judulBuku;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label emailPeminjam;
        private Label kotaPeminjam;
        private Label alamatPeminjam;
        private Label namaPeminjam;
        private Label label12;
        private Label label11;
        private Button btnKonfirmasi;
    }
}