using db_shoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes_Laundry
{
    public partial class FPassword : Form
    {
        Koneksi koneksi2 = new Koneksi();
        public FPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public bool Update( ubah_user change, string id)
        {
            Boolean status = false;
            try
            {
                koneksi2.OpenConnection();
                //ini pesanan yg dr pesanan_m

                koneksi2.ExecuteQuery("update password SET  username='" + change.Username +"', password='" + change.Password +"'");

                    status = true;
                    MessageBox.Show("Data berhasil diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
                catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

    }
}
