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

namespace Shoes_Laundry.view
{
    public partial class dataemployee : Form
    {
        Koneksi koneksi = new Koneksi();
        public dataemployee()
        {
            InitializeComponent();
        }
        public void Tampil()
        {
            ordertable.DataSource = koneksi.ShowData("select * from orderr");
            ordertable.Columns[0].HeaderText = "Oder ID";
            ordertable.Columns[1].HeaderText = "Order Date";
            ordertable.Columns[2].HeaderText = "Employee ID";
            ordertable.Columns[3].HeaderText = "Customer ID";
            ordertable.Columns[4].HeaderText = "Pack ID";
            ordertable.Columns[5].HeaderText = "Total";
            ordertable.Columns[6].HeaderText = "Stat Order";
            ordertable.Columns[6].HeaderText = "Stat Payment";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
