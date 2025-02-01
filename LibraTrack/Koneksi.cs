using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraTrack
{
    internal class Koneksi
    {
        private static readonly string connectionString = "SERVER=localhost;port=3306;database=cafee;UID=root;";
        private readonly MySqlConnection conn;

        public Koneksi()
        {
            conn = new MySqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Koneksi berhasil dibuka.");
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Terjadi kesalahan saat ingin akses database : {err.Message}", "Error Database");
                    Console.WriteLine($"Error membuka koneksi: {err.Message}");
                }
            }
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
