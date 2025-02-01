namespace LibraTrack
{
    partial class KelolaPenggunaForm
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
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dtGridTable = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtNama = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            btnTambah = new Button();
            btnBack = new Button();
            btnExit = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(198, 63);
            label4.Name = "label4";
            label4.Size = new Size(154, 19);
            label4.TabIndex = 39;
            label4.Text = "Kelola daftar pengguna.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 31);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 38;
            label3.Text = "Daftar Pengguna";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(27, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 128);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // dtGridTable
            // 
            dtGridTable.BackgroundColor = Color.FromArgb(15, 83, 122);
            dtGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridTable.Location = new Point(398, 186);
            dtGridTable.Name = "dtGridTable";
            dtGridTable.Size = new Size(379, 283);
            dtGridTable.TabIndex = 41;
            dtGridTable.CellContentClick += dtGridTable_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(398, 140);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 42;
            label1.Text = "Tabel Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(15, 83, 122);
            label2.Location = new Point(401, 161);
            label2.Name = "label2";
            label2.Size = new Size(189, 13);
            label2.TabIndex = 43;
            label2.Text = "Pincet baris untuk mengambil data.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 196);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 45;
            label5.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.FromArgb(217, 217, 217);
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(27, 221);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(321, 35);
            txtNama.TabIndex = 44;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 271);
            label6.Name = "label6";
            label6.Size = new Size(43, 19);
            label6.TabIndex = 47;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 217, 217);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(27, 296);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 35);
            txtEmail.TabIndex = 46;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 346);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 49;
            label7.Text = "password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(217, 217, 217);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(27, 371);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(321, 35);
            txtPassword.TabIndex = 48;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(15, 83, 122);
            btnTambah.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(250, 430);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(98, 39);
            btnTambah.TabIndex = 50;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(15, 83, 122);
            btnBack.Location = new Point(679, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 39);
            btnBack.TabIndex = 51;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(564, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 39);
            btnExit.TabIndex = 52;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkGoldenrod;
            btnEdit.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(137, 430);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 39);
            btnEdit.TabIndex = 53;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.FlatAppearance.BorderColor = Color.Red;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(27, 430);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(98, 39);
            btnHapus.TabIndex = 54;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.FromArgb(15, 83, 122);
            btnReset.Location = new Point(398, 485);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(379, 39);
            btnReset.TabIndex = 55;
            btnReset.Text = "Load Data dan Bersihkan Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // KelolaPenggunaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 536);
            Controls.Add(btnReset);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnTambah);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtGridTable);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KelolaPenggunaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KelolaPenggunaForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dtGridTable;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox txtNama;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPassword;
        private Button btnTambah;
        private Button btnBack;
        private Button btnExit;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnReset;
    }
}