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

namespace LibraTrack
{
    public partial class KelolaBukuForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idBook, title, synopsis, genre, author, publisher, stok;
        public KelolaBukuForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataBuku();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
        }

        private void LoadDataBuku()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT * FROM books";
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
            LoadDataBuku();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;

            this.title = "";
            this.author = "";
            this.synopsis = "";
            this.stok = "";
            this.genre = "";
            this.publisher = "";

            txtJudul.Text = "";
            txtPenerbit.Text = "";
            txtPenulis.Text = "";
            txtStokBuku.Text = "";
            txtGenre.Text = "";
            txtSinopsis.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new PanelAdmin().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void txtJudul_TextChanged(object sender, EventArgs e)
        {
            this.title = txtJudul.Text;
        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {
            this.genre = txtGenre.Text;
        }

        private void txtPenulis_TextChanged(object sender, EventArgs e)
        {
            this.author = txtPenulis.Text;
        }

        private void txtSinopsis_TextChanged(object sender, EventArgs e)
        {
            this.synopsis = txtSinopsis.Text;
        }

        private void txtPenerbit_TextChanged(object sender, EventArgs e)
        {
            this.publisher = txtPenerbit.Text;
        }

        private void txtStokBuku_TextChanged(object sender, EventArgs e)
        {
            this.stok = txtStokBuku.Text;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.openConnection();

                string query = "INSERT INTO books (title, genre, synopsis, stok, author, publisher) VALUES (@Title, @Genre, @Synopsis, @Stok, @Author, @Publisher)";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Title", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@Synopsis", txtSinopsis.Text);
                    cmd.Parameters.AddWithValue("@Stok", txtStokBuku.Text);
                    cmd.Parameters.AddWithValue("@Author", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txtPenerbit.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Buku berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan buku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Terjadi kesalahan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
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

                this.title = row.Cells["title"].Value.ToString() ?? "";
                this.genre = row.Cells["genre"].Value.ToString() ?? "";
                this.synopsis = row.Cells["synopsis"].Value.ToString() ?? "";
                this.stok = row.Cells["stok"].Value.ToString() ?? "";
                this.author = row.Cells["author"].Value.ToString() ?? "";
                this.publisher = row.Cells["publisher"].Value.ToString() ?? "";
                this.idBook = row.Cells["id_book"].Value.ToString() ?? "";

                txtJudul.Text = this.title;
                txtGenre.Text = this.genre;
                txtSinopsis.Text = this.synopsis;
                txtStokBuku.Text = this.stok;
                txtPenulis.Text = this.author;
                txtPenerbit.Text = this.publisher;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idBook))
            {
                MessageBox.Show("Pilih buku yang ingin diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();

                string query = "UPDATE books SET title = @Title, genre = @Genre, synopsis = @Synopsis, stok = @Stok, author = @Author, publisher = @Publisher WHERE id_book = @IdBook";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdBook", idBook);
                    cmd.Parameters.AddWithValue("@Title", txtJudul.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@Synopsis", txtSinopsis.Text);
                    cmd.Parameters.AddWithValue("@Stok", txtStokBuku.Text);
                    cmd.Parameters.AddWithValue("@Author", txtPenulis.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txtPenerbit.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Buku berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui buku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Terjadi kesalahan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idBook))
            {
                MessageBox.Show("Pilih buku yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus buku ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
            {
                return;
            }

            try
            {
                koneksi.openConnection();

                string query = "DELETE FROM books WHERE id_book = @IdBook";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdBook", idBook);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Buku berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus buku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Terjadi kesalahan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }
    }
}
