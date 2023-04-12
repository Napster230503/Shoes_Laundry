using db_shoes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes_Laundry.view
{
    public partial class showdata : Form
    {
        Koneksi koneksi = new Koneksi();

        public void tampil()
        {
            //DataTable.DataSource = koneksi.ShowData("SELECT * FROM orderr");

            //DataTable.Columns[0].HeaderText = "Order ID";
            //DataTable.Columns[1].HeaderText = "Order Date";
            //DataTable.Columns[2].HeaderText = "Employee ID";
            //DataTable.Columns[3].HeaderText = "Customer ID";
            //DataTable.Columns[4].HeaderText = "Package ID";
            //DataTable.Columns[5].HeaderText = "Total";
            //DataTable.Columns[6].HeaderText = "Status Order";
            //DataTable.Columns[7].HeaderText = "Date Finished";
            //DataTable.Columns[8].HeaderText = "Status Payment";

        }
        public showdata()
        {
            InitializeComponent();
        }

        private void showdatapage_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            HomePage mainform = new HomePage();
            mainform.Show();
        }

        private void ordertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
