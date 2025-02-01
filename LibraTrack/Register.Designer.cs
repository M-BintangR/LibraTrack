namespace LibraTrack
{
    partial class Register
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
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            lblToLogin = new Label();
            btnRegister = new Button();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            label5 = new Label();
            txtNama = new TextBox();
            label6 = new Label();
            txtKota = new TextBox();
            label7 = new Label();
            txtAlamat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(193, 89);
            label4.Name = "label4";
            label4.Size = new Size(222, 19);
            label4.TabIndex = 19;
            label4.Text = "Isi pendaftaran dengan data anda. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 64);
            label3.Name = "label3";
            label3.Size = new Size(263, 25);
            label3.TabIndex = 18;
            label3.Text = "Daftar Ke Aplikasi Sekarang.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 173);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 17;
            label2.Text = "Kata Sandi";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(217, 217, 217);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(263, 198);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 35);
            txtPassword.TabIndex = 16;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 173);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 15;
            label1.Text = "Alamat Surel (email)";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 217, 217);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(21, 198);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 35);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblToLogin
            // 
            lblToLogin.AutoSize = true;
            lblToLogin.BackColor = Color.White;
            lblToLogin.Cursor = Cursors.Hand;
            lblToLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToLogin.ForeColor = Color.FromArgb(19, 146, 167);
            lblToLogin.Location = new Point(296, 552);
            lblToLogin.Name = "lblToLogin";
            lblToLogin.Size = new Size(186, 15);
            lblToLogin.TabIndex = 13;
            lblToLogin.Text = "Sudah punya akun? Masuk di sini.";
            lblToLogin.Click += lblToLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(15, 83, 122);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(363, 497);
            btnRegister.Name = "btnRegister";
            btnRegister.RightToLeft = RightToLeft.No;
            btnRegister.Size = new Size(119, 38);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.libratrack_logo;
            pictureBox2.Location = new Point(21, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 128);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(15, 83, 122);
            btnExit.Location = new Point(238, 497);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 38);
            btnExit.TabIndex = 10;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 255);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 21;
            label5.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.FromArgb(217, 217, 217);
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(21, 280);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(219, 35);
            txtNama.TabIndex = 20;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(261, 255);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 23;
            label6.Text = "Kota Asal";
            // 
            // txtKota
            // 
            txtKota.BackColor = Color.FromArgb(217, 217, 217);
            txtKota.BorderStyle = BorderStyle.None;
            txtKota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtKota.Location = new Point(263, 280);
            txtKota.Multiline = true;
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(219, 35);
            txtKota.TabIndex = 22;
            txtKota.TextChanged += txtKota_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 341);
            label7.Name = "label7";
            label7.Size = new Size(113, 19);
            label7.TabIndex = 25;
            label7.Text = "Alamat Lengkap ";
            // 
            // txtAlamat
            // 
            txtAlamat.BackColor = Color.FromArgb(217, 217, 217);
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAlamat.Location = new Point(21, 366);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(461, 87);
            txtAlamat.TabIndex = 24;
            txtAlamat.TextChanged += txtAlamat_TextChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 583);
            Controls.Add(label7);
            Controls.Add(txtAlamat);
            Controls.Add(label6);
            Controls.Add(txtKota);
            Controls.Add(label5);
            Controls.Add(txtNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(lblToLogin);
            Controls.Add(btnRegister);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtEmail;
        private Label lblToLogin;
        private Button btnRegister;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Label label5;
        private TextBox txtNama;
        private Label label6;
        private TextBox txtKota;
        private Label label7;
        private TextBox txtAlamat;
    }
}