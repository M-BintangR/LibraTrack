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
        public PanelAdmin()
        {
            InitializeComponent();
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
    }
}
