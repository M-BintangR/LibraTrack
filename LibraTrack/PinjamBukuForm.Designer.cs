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
            panel1 = new Panel();
            tanggalPengembalian = new DateTimePicker();
            btnKonfirmasi = new Button();
            judulBuku = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnReset = new Button();
            label5 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtGridTable = new DataGridView();
            dtGridPinjaman = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridPinjaman).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(648, 19);
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
            btnBack.Location = new Point(763, 19);
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
            label4.Location = new Point(198, 65);
            label4.Name = "label4";
            label4.Size = new Size(233, 19);
            label4.TabIndex = 55;
            label4.Text = "Sekarang anda bisa meminjam buku.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 33);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 54;
            label3.Text = "Pinjam Buku";
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(tanggalPengembalian);
            panel1.Controls.Add(btnKonfirmasi);
            panel1.Controls.Add(judulBuku);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(30, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 220);
            panel1.TabIndex = 78;
            // 
            // tanggalPengembalian
            // 
            tanggalPengembalian.Location = new Point(170, 88);
            tanggalPengembalian.Name = "tanggalPengembalian";
            tanggalPengembalian.Size = new Size(200, 23);
            tanggalPengembalian.TabIndex = 80;
            tanggalPengembalian.ValueChanged += tanggalPengembalian_ValueChanged;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.Green;
            btnKonfirmasi.FlatAppearance.BorderColor = Color.Green;
            btnKonfirmasi.FlatStyle = FlatStyle.Flat;
            btnKonfirmasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(25, 151);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(347, 39);
            btnKonfirmasi.TabIndex = 65;
            btnKonfirmasi.Text = "Pinjam Buku Sekarang";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // judulBuku
            // 
            judulBuku.AutoSize = true;
            judulBuku.Location = new Point(25, 94);
            judulBuku.Name = "judulBuku";
            judulBuku.Size = new Size(44, 15);
            judulBuku.TabIndex = 79;
            judulBuku.Text = "label13";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(168, 61);
            label15.Name = "label15";
            label15.Size = new Size(121, 15);
            label15.TabIndex = 78;
            label15.Text = "Waktu Pengembalian";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(25, 61);
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
            label13.Location = new Point(20, 26);
            label13.Name = "label13";
            label13.Size = new Size(183, 19);
            label13.TabIndex = 76;
            label13.Text = "Formulir Penyewaan Buku";
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(15, 83, 122);
            btnReset.Location = new Point(473, 635);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(379, 39);
            btnReset.TabIndex = 77;
            btnReset.Text = "Load Data dan Bersihkan Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(480, 265);
            label5.Name = "label5";
            label5.Size = new Size(36, 13);
            label5.TabIndex = 76;
            label5.Text = "Cari...";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(217, 217, 217);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(532, 256);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(320, 28);
            txtSearch.TabIndex = 75;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(15, 83, 122);
            label2.Location = new Point(476, 226);
            label2.Name = "label2";
            label2.Size = new Size(189, 13);
            label2.TabIndex = 74;
            label2.Text = "Pincet baris untuk mengambil data.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(473, 205);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 73;
            label1.Text = "Tabel Daftar Buku";
            // 
            // dtGridTable
            // 
            dtGridTable.BackgroundColor = Color.FromArgb(15, 83, 122);
            dtGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTable.Location = new Point(473, 303);
            dtGridTable.Name = "dtGridTable";
            dtGridTable.Size = new Size(379, 308);
            dtGridTable.TabIndex = 72;
            dtGridTable.CellContentClick += dtGridTable_CellContentClick;
            // 
            // dtGridPinjaman
            // 
            dtGridPinjaman.BackgroundColor = Color.FromArgb(15, 83, 122);
            dtGridPinjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridPinjaman.Location = new Point(30, 488);
            dtGridPinjaman.Name = "dtGridPinjaman";
            dtGridPinjaman.Size = new Size(401, 186);
            dtGridPinjaman.TabIndex = 79;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(30, 451);
            label7.Name = "label7";
            label7.Size = new Size(157, 19);
            label7.TabIndex = 80;
            label7.Text = "Tabel Daftar Pinjaman";
            // 
            // PinjamBukuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(879, 699);
            Controls.Add(label7);
            Controls.Add(dtGridPinjaman);
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
            Name = "PinjamBukuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PinjamBukuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridPinjaman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnBack;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnKonfirmasi;
        private Label judulBuku;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button btnReset;
        private Label label5;
        private TextBox txtSearch;
        private Label label2;
        private Label label1;
        private DataGridView dtGridTable;
        private DateTimePicker tanggalPengembalian;
        private DataGridView dtGridPinjaman;
        private Label label7;
    }
}