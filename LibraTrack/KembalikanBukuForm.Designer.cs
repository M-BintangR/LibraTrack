namespace LibraTrack
{
    partial class KembalikanBukuForm
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
            btnKonfirmasi = new Button();
            waktuPengembalian = new Label();
            judulBuku = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            status = new Label();
            lblStatus = new Label();
            btnReset = new Button();
            label5 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtGridTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(639, 18);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 39);
            btnExit.TabIndex = 62;
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
            btnBack.Location = new Point(754, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 39);
            btnBack.TabIndex = 61;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(194, 64);
            label4.Name = "label4";
            label4.Size = new Size(263, 19);
            label4.TabIndex = 60;
            label4.Text = "Sekarang anda bisa mengembalikan buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 32);
            label3.Name = "label3";
            label3.Size = new Size(256, 25);
            label3.TabIndex = 59;
            label3.Text = "Kembalikan Buku Pinjaman";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(23, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 128);
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
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
            panel1.Controls.Add(status);
            panel1.Controls.Add(lblStatus);
            panel1.Location = new Point(23, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 336);
            panel1.TabIndex = 71;
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.Lime;
            btnKonfirmasi.FlatAppearance.BorderColor = Color.Lime;
            btnKonfirmasi.FlatStyle = FlatStyle.Flat;
            btnKonfirmasi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.ForeColor = Color.White;
            btnKonfirmasi.Location = new Point(23, 278);
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
            waktuPengembalian.Location = new Point(195, 193);
            waktuPengembalian.Name = "waktuPengembalian";
            waktuPengembalian.Size = new Size(44, 15);
            waktuPengembalian.TabIndex = 80;
            waktuPengembalian.Text = "label13";
            // 
            // judulBuku
            // 
            judulBuku.AutoSize = true;
            judulBuku.Location = new Point(30, 193);
            judulBuku.Name = "judulBuku";
            judulBuku.Size = new Size(44, 15);
            judulBuku.TabIndex = 79;
            judulBuku.Text = "label13";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(195, 160);
            label15.Name = "label15";
            label15.Size = new Size(121, 15);
            label15.TabIndex = 78;
            label15.Text = "Waktu Pengembalian";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(30, 160);
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
            label13.Location = new Point(25, 125);
            label13.Name = "label13";
            label13.Size = new Size(77, 19);
            label13.TabIndex = 76;
            label13.Text = "Data Buku";
            // 
            // status
            // 
            status.AutoSize = true;
            status.BackColor = Color.Red;
            status.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            status.ForeColor = Color.White;
            status.Location = new Point(25, 74);
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
            lblStatus.Location = new Point(25, 46);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(136, 19);
            lblStatus.TabIndex = 65;
            lblStatus.Text = "Status Peminjaman";
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(15, 83, 122);
            btnReset.Location = new Point(466, 494);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(379, 39);
            btnReset.TabIndex = 70;
            btnReset.Text = "Load Data dan Bersihkan Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(473, 254);
            label5.Name = "label5";
            label5.Size = new Size(36, 13);
            label5.TabIndex = 69;
            label5.Text = "Cari...";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(217, 217, 217);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(525, 245);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(320, 28);
            txtSearch.TabIndex = 68;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(15, 83, 122);
            label2.Location = new Point(469, 215);
            label2.Name = "label2";
            label2.Size = new Size(189, 13);
            label2.TabIndex = 67;
            label2.Text = "Pincet baris untuk mengambil data.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(466, 194);
            label1.Name = "label1";
            label1.Size = new Size(128, 19);
            label1.TabIndex = 66;
            label1.Text = "Tabel Daftar Buku";
            // 
            // dtGridTable
            // 
            dtGridTable.BackgroundColor = Color.FromArgb(15, 83, 122);
            dtGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTable.Location = new Point(466, 292);
            dtGridTable.Name = "dtGridTable";
            dtGridTable.Size = new Size(379, 183);
            dtGridTable.TabIndex = 65;
            dtGridTable.CellContentClick += dtGridTable_CellContentClick;
            // 
            // KembalikanBukuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(871, 551);
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
            Name = "KembalikanBukuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KembalikanBukuForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).EndInit();
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
        private Label waktuPengembalian;
        private Label judulBuku;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lblStatus;
        private Button btnReset;
        private Label label5;
        private TextBox txtSearch;
        private Label label2;
        private Label label1;
        private DataGridView dtGridTable;
        private Label status;
    }
}