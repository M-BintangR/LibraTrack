namespace LibraTrack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            lblToRegister = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(15, 83, 122);
            btnExit.Location = new Point(27, 472);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(278, 38);
            btnExit.TabIndex = 0;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libratrack_logo;
            pictureBox1.Location = new Point(89, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 128);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(15, 83, 122);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(15, 83, 122);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(27, 424);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(278, 38);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblToRegister
            // 
            lblToRegister.AutoSize = true;
            lblToRegister.BackColor = Color.White;
            lblToRegister.Cursor = Cursors.Hand;
            lblToRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToRegister.ForeColor = Color.FromArgb(19, 146, 167);
            lblToRegister.Location = new Point(45, 525);
            lblToRegister.Name = "lblToRegister";
            lblToRegister.Size = new Size(234, 15);
            lblToRegister.TabIndex = 3;
            lblToRegister.Text = "Belum punya akun? Klik disini untuk daftar.";
            lblToRegister.Click += lblToRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(217, 217, 217);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(27, 266);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 35);
            txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 241);
            label1.Name = "label1";
            label1.Size = new Size(137, 19);
            label1.TabIndex = 5;
            label1.Text = "Alamat Surel (email)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 327);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 7;
            label2.Text = "Kata Sandi";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(217, 217, 217);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(27, 352);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 35);
            txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 166);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 8;
            label3.Text = "Masuk Ke Aplikasi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(15, 83, 122);
            label4.Location = new Point(69, 193);
            label4.Name = "label4";
            label4.Size = new Size(195, 15);
            label4.TabIndex = 9;
            label4.Text = "Masukkan data anda dengan benar.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(332, 573);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(lblToRegister);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label lblToRegister;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
    }
}
