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
    public partial class KelolaPinjamanForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idRentBook, statusRental, konfirmasi;
        private string query = @"SELECT 
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
            ON rent_books.book_id = books.id_book";

        public KelolaPinjamanForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataPinjaman();

            namaPeminjam.Text = "***";
            alamatPeminjam.Text = "***";
            kotaPeminjam.Text = "***";
            emailPeminjam.Text = "***";

            judulBuku.Text = "***";
            waktuPengembalian.Text = "***";

            this.status.Visible = false;
            this.lblStatus.Visible = false;

            this.btnKonfirmasi.Visible = false;
        }

        public void LoadDataPinjaman()
        {
            try
            {
                koneksi.openConnection();

                using (MySqlCommand cmd = new MySqlCommand(this.query, koneksi.GetConnection()))
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
            LoadDataPinjaman();

            namaPeminjam.Text = "***";
            alamatPeminjam.Text = "***";
            kotaPeminjam.Text = "***";
            emailPeminjam.Text = "***";

            judulBuku.Text = "***";
            waktuPengembalian.Text = "***";

            this.status.Visible = false;
            this.lblStatus.Visible = false;

            this.btnKonfirmasi.Visible = false;
        }

        private void resetStatus()
        {
            if (statusRental == "RENT")
            {
                this.btnKonfirmasi.Visible = false;
                this.status.Text = "SEDANG DI SEWAKAN";
                this.status.BackColor = Color.DarkOrange;
            }

            if (statusRental == "FINISH")
            {
                if (konfirmasi == "NONE")
                {
                    this.btnKonfirmasi.Visible = true;
                    this.status.Text = "SELESAI BACA (BELUM DI KONFIRMASI)";
                    this.status.BackColor = Color.Red;
                }
                else
                {
                    this.btnKonfirmasi.Visible = false;
                    this.status.Text = "TELAH DI KEMBALIKAN (SUDAH DI KONFIRMASI)";
                    this.status.BackColor = Color.Lime;
                }
            }
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

        private void dtGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resetData();
            this.btnKonfirmasi.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridTable.Rows[e.RowIndex];

                this.emailPeminjam.Text = row.Cells["email"].Value.ToString() ?? "";
                this.namaPeminjam.Text = row.Cells["nama_peminjam"].Value.ToString() ?? "";
                this.kotaPeminjam.Text = row.Cells["kota"].Value.ToString() ?? "";
                this.alamatPeminjam.Text = row.Cells["alamat"].Value.ToString() ?? "";

                this.judulBuku.Text = row.Cells["judul_buku"].Value.ToString() ?? "";
                this.waktuPengembalian.Text = row.Cells["tanggal_selesai"].Value.ToString() ?? "";
                this.idRentBook = row.Cells["id_rent_book"].Value.ToString() ?? "";

                this.statusRental = row.Cells["status_rental"].Value.ToString() ?? "";
                this.konfirmasi = row.Cells["konfirmasi_admin"].Value.ToString() ?? "";

                this.lblStatus.Visible = true;
                this.status.Visible = true;

                resetStatus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.idRentBook))
            {
                MessageBox.Show("Pilih data peminjam terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Apakah anda yakin ingin menyetujui pengembalian, apa yang anda lakukan tidak dapat di kembalikan.?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    koneksi.openConnection();

                    string query = "UPDATE rent_books SET status_admin = @StatusAdmin WHERE id_rent_book = @IdRentBook";


                    using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@IdRentBook", this.idRentBook);
                        cmd.Parameters.AddWithValue("@StatusAdmin", "RETURNED");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Anda telah menyetujui pengembalian buku!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetStatus();
                            resetData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyetujui pengembalian!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Gagal menyetujui pengembalian: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"Error: {err.Message}");
                }
                finally
                {
                    koneksi.CloseConnection();
                }
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
    }
}
