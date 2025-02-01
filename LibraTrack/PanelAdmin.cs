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
    public partial class PanelAdmin : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string queryTotalAdmin = @"SELECT count(*) FROM users WHERE role = 'admin'";
        private string queryTotalPengguna = @"SELECT count(*) FROM users WHERE role = 'user'";
        private string queryTotalPinjaman = @"SELECT count(*) FROM rent_books";
        private string queryTotalPinjamanSelesai = @"SELECT count(*) FROM rent_books WHERE status_admin = 'RETURNED'";
        private string queryTotalBuku = @"SELECT count(*) FROM books";
        private string queryTotalBelumKonfirmasi = @"SELECT count(*) FROM rent_books 
            WHERE status_rent = 'FINISH' AND status_admin = 'NONE'";

        public PanelAdmin()
        {
            InitializeComponent();
            koneksi = new Koneksi();

            this.totalAdmin.Text = "0";
            this.totalPengguna.Text = "0";
            this.totalPinjaman.Text = "0";
            this.totalPinjamanSelesai.Text = "0";
            this.totalBuku.Text = "0";
            this.totalBelumKonfirmasi.Text = "0";

            LoadCountData();
        }

        private void LoadCountData()
        {
            try
            {
                koneksi.openConnection();
                this.totalAdmin.Text = GetCount(queryTotalAdmin);
                this.totalPengguna.Text = GetCount(queryTotalPengguna);
                this.totalPinjaman.Text = GetCount(queryTotalPinjaman);
                this.totalPinjamanSelesai.Text = GetCount(queryTotalPinjamanSelesai);
                this.totalBuku.Text = GetCount(queryTotalBuku);
                this.totalBelumKonfirmasi.Text = GetCount(queryTotalBelumKonfirmasi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private string GetCount(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
            {
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "0";
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            new KelolaPenggunaForm().Show();
            this.Hide();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            new KelolaBukuForm().Show();
            this.Hide();
        }

        private void btnPinjaman_Click(object sender, EventArgs e)
        {
            new KelolaPinjamanForm().Show();
            this.Hide();
        }
    }
}
