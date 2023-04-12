using db_shoes;
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

namespace Shoes_Laundry.view
{
    public partial class showdata : Form
    {
        Koneksi koneksi2 = new Koneksi();
        public showdata()
        {
            InitializeComponent();
        }

        private void showdatapage_Load(object sender, EventArgs e)
        {
            
        }

        //public void Tampil()
        //{
        //    DataTable.DataSource = koneksi.ShowData("select * from orderr");
        //    DataTable.Columns[0].HeaderText = "Order ID";
        //    DataTable.Columns[1].HeaderText = "Order Date";
        //    DataTable.Columns[2].HeaderText = "Employee ID";
        //    DataTable.Columns[3].HeaderText = "Customer ID";
        //    DataTable.Columns[4].HeaderText = "Package ID";
        //    DataTable.Columns[5].HeaderText = "Total";
        //    DataTable.Columns[6].HeaderText = "Status Order";
        //    DataTable.Columns[7].HeaderText = "Date Finished";
        //    DataTable.Columns[8].HeaderText = "Status Payment";
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
