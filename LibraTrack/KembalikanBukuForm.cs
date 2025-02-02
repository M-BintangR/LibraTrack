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
    public partial class KembalikanBukuForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idRentBook, statusRental, konfirmasi, dateFinish;

        public KembalikanBukuForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataPinjaman();

            this.lblStatus.Visible = false;
            this.status.Visible = false;
            this.btnKonfirmasi.Visible = false;

            this.judulBuku.Text = "***";
            this.waktuPengembalian.Text = "***";
        }

        private void LoadDataPinjaman()
        {
            try
            {
                koneksi.openConnection();

                string query = @"SELECT 
                    users.name AS 'nama_peminjam',
                    users.email AS 'email',
                    users.city AS 'kota',
                    users.address AS 'alamat',
                    books.title AS 'judul_buku',
                    books.genre AS 'genre',
                    books.stok AS 'stok',
                    books.synopsis AS 'sinopsis',
                    books.author AS 'penulis',
                    books.publisher AS 'penerbit',
                    rent_books.date_rent AS 'tanggal_pinjam',
                    rent_books.date_finish AS 'tanggal_selesai',
                    rent_books.status_rent AS 'status_rental',
                    rent_books.status_admin AS 'konfirmasi_admin',
                    rent_books.book_id AS 'book_id',
                    rent_books.user_id AS 'user_id',
                    rent_books.id_rent_book AS 'id_rent_book'
                FROM rent_books 
                INNER JOIN users 
                    ON rent_books.user_id = users.id_user 
                INNER JOIN books 
                    ON rent_books.book_id = books.id_book
                WHERE users.id_user = @IdUser";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    string idUser = UserSession.UserCurrent.Id;

                    cmd.Parameters.AddWithValue("@IdUser", idUser);

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
            LoadDataPinjaman();

            this.lblStatus.Visible = false;
            this.status.Visible = false;
            this.btnKonfirmasi.Visible = false;

            this.judulBuku.Text = "***";
            this.waktuPengembalian.Text = "***";
        }

        private void resetStatus()
        {
            if (statusRental == "RENT")
            {
                DateTime dateFinishParsed;
                if (DateTime.TryParse(this.dateFinish, out dateFinishParsed))
                {
                    if (dateFinishParsed >= DateTime.Now)
                    {
                        this.btnKonfirmasi.Visible = false;
                        this.status.Text = "BELUM BISA DI KEMBALIKAN";
                        this.status.BackColor = Color.Lime;
                    }
                    else
                    {
                        this.btnKonfirmasi.Visible = true;
                        this.status.Text = "BELUM DI KEMBALIKAN";
                        this.status.BackColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Format tanggal tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (statusRental == "FINISH")
            {
                this.btnKonfirmasi.Visible = false;

                if (konfirmasi == "NONE")
                {
                    this.status.Text = "PENGEMBALIAN BELUM DI KONFIRMASI";
                    this.status.BackColor = Color.DarkOrange;
                }
                else
                {
                    this.status.Text = "TELAH DI KEMBALIKAN (SUDAH DI KONFIRMASI)";
                    this.status.BackColor = Color.Lime;
                }
            }
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

        private void dtGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetData();
            this.btnKonfirmasi.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridTable.Rows[e.RowIndex];

                this.judulBuku.Text = row.Cells["judul_buku"].Value.ToString() ?? "";
                this.waktuPengembalian.Text = row.Cells["tanggal_selesai"].Value.ToString() ?? "";
              

                this.statusRental = row.Cells["status_rental"].Value.ToString() ?? "";
                this.konfirmasi = row.Cells["konfirmasi_admin"].Value.ToString() ?? "";
                this.idRentBook = row.Cells["id_rent_book"].Value.ToString() ?? "";
                this.dateFinish = row.Cells["tanggal_selesai"].Value.ToString() ?? "";

                this.lblStatus.Visible = true;
                this.status.Visible = true;

                resetStatus();
            }
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
            dv.RowFilter = $"nama_peminjam LIKE '%{searchValue}%' OR judul_buku LIKE '%{searchValue}%'";
            dtGridTable.DataSource = dv;
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.idRentBook))
            {
                MessageBox.Show("Pilih buku pinjaman terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = @"UPDATE rent_books SET status_rent = 'FINISH' WHERE id_rent_book = @IdRentBook";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    string dateRent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string userId = UserSession.UserCurrent.Id;

                    cmd.Parameters.AddWithValue("@IdRentBook", this.idRentBook);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Anda berhasil mengembalikan buku!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Anda gagal mengembalikan buku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Anda gagal mengembalikan buku: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
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
