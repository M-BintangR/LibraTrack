using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraTrack
{
    internal class LoginApp
    {
        private string email;
        private string password;
        private readonly Koneksi koneksi;

        public LoginApp(string email, string password)
        {
            this.email = email;
            this.password = password;
            this.koneksi = new Koneksi();
        }

        public bool VerifyLogin()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role"].ToString() ?? "";

                            MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (role == "admin")
                            {
                                new PanelAdmin().Show();
                            }
                            else if (role == "user")
                            {
                                new PenggunaPanel().Show();
                            }

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Email atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Terjadi kesalahan saat login: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
                return false;
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
