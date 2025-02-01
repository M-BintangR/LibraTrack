namespace LibraTrack
{
    partial class KelolaBukuForm
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
            btnReset = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            btnBack = new Button();
            btnTambah = new Button();
            label6 = new Label();
            txtGenre = new TextBox();
            label5 = new Label();
            txtJudul = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtGridTable = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtStokBuku = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtPenulis = new TextBox();
            label9 = new Label();
            txtPenerbit = new TextBox();
            label10 = new Label();
            txtSinopsis = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(15, 83, 122);
            btnReset.Location = new Point(430, 506);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(338, 39);
            btnReset.TabIndex = 73;
            btnReset.Text = "Load Data dan Bersihkan Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.FlatAppearance.BorderColor = Color.Red;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(52, 506);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(98, 39);
            btnHapus.TabIndex = 72;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkGoldenrod;
            btnEdit.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(162, 506);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 39);
            btnEdit.TabIndex = 71;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(555, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 39);
            btnExit.TabIndex = 70;
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
            btnBack.Location = new Point(670, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 39);
            btnBack.TabIndex = 69;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(15, 83, 122);
            btnTambah.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(275, 506);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(98, 39);
            btnTambah.TabIndex = 68;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(225, 174);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 65;
            label6.Text = "Genre Buku";
            // 
            // txtGenre
            // 
            txtGenre.BackColor = Color.FromArgb(217, 217, 217);
            txtGenre.BorderStyle = BorderStyle.None;
            txtGenre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGenre.Location = new Point(225, 199);
            txtGenre.Multiline = true;
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(183, 35);
            txtGenre.TabIndex = 64;
            txtGenre.TextChanged += txtGenre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 174);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 63;
            label5.Text = "Judul Buku";
            // 
            // txtJudul
            // 
            txtJudul.BackColor = Color.FromArgb(217, 217, 217);
            txtJudul.BorderStyle = BorderStyle.None;
            txtJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtJudul.Location = new Point(18, 199);
            txtJudul.Multiline = true;
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(183, 35);
            txtJudul.TabIndex = 62;
            txtJudul.TextChanged += txtJudul_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(15, 83, 122);
            label2.Location = new Point(433, 139);
            label2.Name = "label2";
            label2.Size = new Size(189, 13);
            label2.TabIndex = 61;
            label2.Text = "Pincet baris untuk mengambil data.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(430, 118);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 60;
            label1.Text = "Tabel Buku";
            // 
            // dtGridTable
            // 
            dtGridTable.BackgroundColor = Color.FromArgb(15, 83, 122);
            dtGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTable.Location = new Point(430, 164);
            dtGridTable.Name = "dtGridTable";
            dtGridTable.Size = new Size(338, 308);
            dtGridTable.TabIndex = 59;
            dtGridTable.CellContentClick += dtGridTable_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(189, 51);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 58;
            label4.Text = "Kelola daftar buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 19);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 57;
            label3.Text = "Daftar Buku";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(18, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 128);
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // txtStokBuku
            // 
            txtStokBuku.BackColor = Color.FromArgb(217, 217, 217);
            txtStokBuku.BorderStyle = BorderStyle.None;
            txtStokBuku.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStokBuku.Location = new Point(18, 437);
            txtStokBuku.Multiline = true;
            txtStokBuku.Name = "txtStokBuku";
            txtStokBuku.Size = new Size(183, 35);
            txtStokBuku.TabIndex = 74;
            txtStokBuku.TextChanged += txtStokBuku_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 411);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 75;
            label7.Text = "Stok Buku";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(16, 255);
            label8.Name = "label8";
            label8.Size = new Size(54, 19);
            label8.TabIndex = 77;
            label8.Text = "Penulis";
            // 
            // txtPenulis
            // 
            txtPenulis.BackColor = Color.FromArgb(217, 217, 217);
            txtPenulis.BorderStyle = BorderStyle.None;
            txtPenulis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPenulis.Location = new Point(16, 281);
            txtPenulis.Multiline = true;
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(183, 35);
            txtPenulis.TabIndex = 76;
            txtPenulis.TextChanged += txtPenulis_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 334);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 79;
            label9.Text = "Nama Penerbit";
            // 
            // txtPenerbit
            // 
            txtPenerbit.BackColor = Color.FromArgb(217, 217, 217);
            txtPenerbit.BorderStyle = BorderStyle.None;
            txtPenerbit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPenerbit.Location = new Point(18, 360);
            txtPenerbit.Multiline = true;
            txtPenerbit.Name = "txtPenerbit";
            txtPenerbit.Size = new Size(183, 35);
            txtPenerbit.TabIndex = 78;
            txtPenerbit.TextChanged += txtPenerbit_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(225, 255);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 81;
            label10.Text = "Sinopsis";
            // 
            // txtSinopsis
            // 
            txtSinopsis.BackColor = Color.FromArgb(217, 217, 217);
            txtSinopsis.BorderStyle = BorderStyle.None;
            txtSinopsis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSinopsis.Location = new Point(225, 281);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(183, 191);
            txtSinopsis.TabIndex = 80;
            txtSinopsis.TextChanged += txtSinopsis_TextChanged;
            // 
            // KelolaBukuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 577);
            Controls.Add(label10);
            Controls.Add(txtSinopsis);
            Controls.Add(label9);
            Controls.Add(txtPenerbit);
            Controls.Add(label8);
            Controls.Add(txtPenulis);
            Controls.Add(label7);
            Controls.Add(txtStokBuku);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnTambah);
            Controls.Add(label6);
            Controls.Add(txtGenre);
            Controls.Add(label5);
            Controls.Add(txtJudul);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtGridTable);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KelolaBukuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KelolaBukuForm";
            ((System.ComponentModel.ISupportInitialize)dtGridTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnExit;
        private Button btnBack;
        private Button btnTambah;
        private Label label6;
        private TextBox txtGenre;
        private Label label5;
        private TextBox txtJudul;
        private Label label2;
        private Label label1;
        private DataGridView dtGridTable;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtStokBuku;
        private Label label7;
        private Label label8;
        private TextBox txtPenulis;
        private Label label9;
        private TextBox txtPenerbit;
        private Label label10;
        private TextBox txtSinopsis;
    }
}