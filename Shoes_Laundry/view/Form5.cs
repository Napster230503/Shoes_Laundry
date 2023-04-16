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
            Tampil();
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
            Tampil();
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
            ordertable.Rows.Clear();
            string conStr;
            conStr = "server=localhost;port=3306;database=shoes_laundry;uid=root;password=;";

            conn = new MySqlConnection(conStr);
            conn.Open();
            try
            {
                cmd = new MySqlCommand("Select * From orderr where '%"+txtSrc+"%' or stat_payment like '%"+ordertable.Text+"%'or order_date like '%"+ordertable.Text+"%'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ordertable.Rows.Add(reader["order_id"].ToString(), reader["order_date"].ToString(), reader["emp_id"].ToString(), reader["cust_id"].ToString(), reader["pack_id"].ToString(), reader["stat_order"].ToString(), reader["stat_payment"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ordertable.Rows.Clear();
            string conStr;
            conStr = "server=localhost;port=3306;database=shoes_laundry;uid=root;password=;";

            conn = new MySqlConnection(conStr);
            conn.Open();
            try
            { 
                cmd = new MySqlCommand("Select * From orderr", conn);
                reader = cmd.ExecuteReader();   
                while (reader.Read()) 
                {
                    ordertable.Rows.Add(reader["order_id"].ToString(), reader["order_date"].ToString(), reader["emp_id"].ToString(), reader["cust_id"].ToString(), reader["pack_id"].ToString(), reader["stat_order"].ToString(), reader["stat_payment"].ToString());
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
