using db_shoes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shoes_Laundry.view
{
    public partial class showdata : Form
    {
        Koneksi koneksi = new Koneksi();

        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        public showdata()
        {
            InitializeComponent();
        }

        private void showdatapage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            HomePage mainform = new HomePage();
            mainform.Show();
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
            ordertable.Columns[7].HeaderText = "Stat Payment";
        }
        private void ordertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
   
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        //SRC

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSrc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string connectionString = "Server=localhost;Database=shoes_laundry;Uid=root;Pwd=;";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM orderr WHERE pack_id LIKE @search";

            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("@search", "%" + txtSrc.Text + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            ordertable.DataSource = table;

            con.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Tampil();
        }
    }
}

//order_id, order_date, emp_id, cust_id, pack_id, stat_order, stat_payment