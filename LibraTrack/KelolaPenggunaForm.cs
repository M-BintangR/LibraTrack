using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraTrack
{
    public partial class KelolaPenggunaForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idUser, name, email, password, role = "user";
        public KelolaPenggunaForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataPengguna();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
        }

        private void LoadDataPengguna()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT * FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridTable.DataSource = dataTable;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memuat data pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void resetData()
        {
            LoadDataPengguna();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;

            this.email = "";
            this.password = "";
            this.name = "";

            txtNama.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new PanelAdmin().Show();
            this.Hide();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            this.name = txtNama.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.email) || string.IsNullOrWhiteSpace(this.password) || string.IsNullOrWhiteSpace(this.name))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "INSERT INTO users (email, password, name, role) VALUES (@Email, @Password, @Name, @Role)";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", this.email);
                    cmd.Parameters.AddWithValue("@Password", this.password);
                    cmd.Parameters.AddWithValue("@Name", this.name);
                    cmd.Parameters.AddWithValue("@Role", this.role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pengguna berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menambah pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
              if (string.IsNullOrWhiteSpace(this.email) || string.IsNullOrWhiteSpace(this.name) || string.IsNullOrWhiteSpace(this.idUser))
            {
                MessageBox.Show("Email dan Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();

                string query;
                if (!string.IsNullOrWhiteSpace(this.password))
                {
                    query = "UPDATE users SET name = @Name, role = @Role, password = @Password WHERE id_user = @IdUser";
                }
                else
                {
                    query = "UPDATE users SET name = @Name, role = @Role WHERE id_user = @IdUser";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", this.email);
                    cmd.Parameters.AddWithValue("@Name", this.name);
                    cmd.Parameters.AddWithValue("@Role", this.role);
                    cmd.Parameters.AddWithValue("@IdUser", this.idUser);

                    if (!string.IsNullOrWhiteSpace(this.password))
                    {
                        cmd.Parameters.AddWithValue("@Password", this.password);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pengguna berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memperbarui pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.idUser))
            {
                MessageBox.Show("Pilih pengguna yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna {this.name}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    koneksi.openConnection();
                    string query = "DELETE FROM users WHERE id_user = @IdUser";

                    using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Iduser", this.idUser);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pengguna berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Gagal menghapus pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"Error: {err.Message}");
                }
                finally
                {
                    koneksi.CloseConnection();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void dtGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetData();

            this.btnTambah.Enabled = false;
            this.btnEdit.Enabled = true;
            this.btnHapus.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridTable.Rows[e.RowIndex];

                this.email = row.Cells["email"].Value.ToString() ?? "";
                this.name = row.Cells["name"].Value.ToString() ?? "";
                this.role = row.Cells["role"].Value.ToString() ?? "";
                this.idUser = row.Cells["id_user"].Value.ToString() ?? "";

                txtEmail.Text = this.email;
                txtNama.Text = this.name;
            }
        }
    }
}
