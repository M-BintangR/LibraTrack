using LibraTrack.Session;
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
    public partial class PinjamBukuForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idBook,date,title;
        public PinjamBukuForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataBuku();
            LoadDataPinjaman();

            judulBuku.Text = "***";
            this.date = tanggalPengembalian.Value.ToString("yyyy-MM-dd");
        }

        private void LoadDataBuku()
        {
            try
            {
                koneksi.openConnection();

                 string query = @"SELECT * FROM books";

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
                MessageBox.Show($"Gagal memuat data buku: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void LoadDataPinjaman()
        {
            try
            {
                koneksi.openConnection();

                string query = @"SELECT * FROM rent_books WHERE user_id = @IdUser AND status_rent = 'RENT' AND status_admin = 'NONE'";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    string userId = UserSession.UserCurrent.Id ?? "";
                    cmd.Parameters.AddWithValue("@IdUser", userId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtGridPinjaman.DataSource = dataTable;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memuat data pinjaman: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void resetData()
        {
            this.date = tanggalPengembalian.Value.ToString("yyyy-MM-dd");
            tanggalPengembalian.Value = DateTime.Now;
            LoadDataBuku();
            LoadDataPinjaman();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new PenggunaPanel().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.date) || string.IsNullOrWhiteSpace(this.idBook))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = @"INSERT INTO rent_books (book_id, user_id, date_rent, date_finish) 
                    VALUES (@IdBook, @IdUser, @DateRent, @DateFinish)";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    string dateRent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string userId = UserSession.UserCurrent.Id;

                    cmd.Parameters.AddWithValue("@IdBook", this.idBook);
                    cmd.Parameters.AddWithValue("@IdUser", userId);
                    cmd.Parameters.AddWithValue("@DateRent", dateRent);
                    cmd.Parameters.AddWithValue("@DateFinish", this.date);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Anda berhasil meminjam buku!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Anda gagal meminjam buku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Anda gagal meminjam buku: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void tanggalPengembalian_ValueChanged(object sender, EventArgs e)
        {
            this.date = tanggalPengembalian.Value.ToString("yyyy-MM-dd");
        }

        private void dtGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetData();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridTable.Rows[e.RowIndex];

                this.title = row.Cells["title"].Value.ToString() ?? "";
                this.idBook = row.Cells["id_book"].Value.ToString() ?? "";

                judulBuku.Text = this.title;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtGridTable.DataSource = dataTable;
                return;
            }

            DataView dv = new DataView(dataTable);
            dv.RowFilter = $"title LIKE '%{searchValue}%' OR genre LIKE '%{searchValue}%'";
            dtGridTable.DataSource = dv;
        }


    }
}
