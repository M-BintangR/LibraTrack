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
            if(this.email == "admin@gmail.com" && this.password == "adminadmin")
            {
                new PanelAdmin().Show();
            }else if(this.email == "user@gmail.com" && this.password == "useruser")
            {
                new PenggunaPanel().Show();
            }
            else
            {
                MessageBox.Show("Ada yang salah : password atau email anda mungkin salah, cek kembali data anda!", "Terjadi kesalahan.");
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
