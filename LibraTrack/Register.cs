using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraTrack
{
    public partial class Register : Form
    {
        private string password, name, email, city, address;
        public Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblToLogin_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterApp register = new RegisterApp(this.name, this.email, this.password, this.city, this.address);

            if (register.RegisterData())
            {
                MessageBox.Show("Anda berhasil terdaftar!", "Berhasil");
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Ada yang salah, anda tidak dapat pendaftar, cek kembali data anda", "Pesan kesalahan");
                new Register().Show();
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

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            this.name = txtNama.Text;
        }

        private void txtKota_TextChanged(object sender, EventArgs e)
        {
            this.city = txtKota.Text;
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            this.address = txtAlamat.Text;
        }
    }
}
