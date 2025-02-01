using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraTrack
{
    internal class RegisterApp
    {
        private string name, email, password, city, address, role;
        private readonly Koneksi koneksi;

        public RegisterApp(string name, string email, string password, string city, string address, string role = "user")
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.city = city;
            this.address = address;
            this.role = role;
            this.koneksi = new Koneksi();
        }

        public bool RegisterData()
        {
            try
            {
                koneksi.openConnection();

                string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @Email";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, koneksi.GetConnection()))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Email sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                string query = "INSERT INTO users (name, email, password, city, address, role) VALUES (@Name, @Email, @Password, @City, @Address, @Role)";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registrasi berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Registrasi gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Terjadi kesalahan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
