using Microsoft.VisualBasic.Logging;

namespace LibraTrack
{
    public partial class Form1 : Form
    {
        private string email, password;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblToRegister_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginApp login = new LoginApp(this.email, this.password);

            if (login.VerifyLogin())
            {
                MessageBox.Show("Anda berhasil login!", "Berhasil");
            }
            else
            {
                MessageBox.Show("Ada yang salah, anda tidak dapat login, cek kembali password & email anda", "Pesan kesalahan");
                new Form1().Show();
            }

            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }
    }
}
