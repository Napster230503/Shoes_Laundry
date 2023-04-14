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
using System.Xml.Linq;

namespace Shoes_Laundry.view
{
    public partial class insertdata : Form
    {
        Koneksi koneksi = new Koneksi();
        //string query;
        public void isiinsert()
        {
            try
            {
                string konek = "Server=localhost;Database=shoes_laundry;Uid=root;Pwd=;";

                MySqlConnection con;
                con = new MySqlConnection(konek);
                con.Open();

                MySqlConnection con2;
                con2 = new MySqlConnection(konek);
                con2.Open();

                MySqlConnection con3;
                con3 = new MySqlConnection(konek);
                con3.Open();

                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand cmd2 = new MySqlCommand();
                MySqlCommand cmd3 = new MySqlCommand();

                cmd.Connection = con;
                cmd2.Connection = con2;
                cmd3.Connection = con3;

                String querya = "Select * from employee";
                String query2 = "Select * from customer";
                String query3 = "Select * from package";

                cmd.CommandText = querya;
                cmd2.CommandText = query2;
                cmd3.CommandText = query3;

                MySqlDataReader reader = cmd.ExecuteReader();
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                MySqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["emp_id"].ToString()/* + " - " + reader["emp_name"].ToString()*/);
                }

                con.Close();


                while (reader2.Read())
                {

                    comboBox2.Items.Add(reader2["cust_id"].ToString()/* + " - " + reader2["cust_name"].ToString()*/);
                }


                con2.Close();

                while (reader3.Read())
                {
                    comboBox3.Items.Add(reader3["pack_id"].ToString()/* + " - " + reader3["pack_name"].ToString()*/);
                }

                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

            
                //Isian semua data            
               
            

        }
        public void insertkedb()
        {
            string orderdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string empid = comboBox1.Text.Trim();
            string custid = comboBox2.Text.Trim();
            string packid = comboBox3.Text.Trim();
            string total = textBox1.Text.Trim();
            string statorder = comboBox4.Text.Trim();
            string statpayment = comboBox5.Text.Trim();


            string query = "INSERT INTO orderr (order_date, emp_id, cust_id, pack_id, total, stat_order, stat_payment) VALUES (@orderdate, @empid, @custid, @packid,  @total, @statorder, @statpayment)";
            try
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=shoes_laundry;uid=root;password=;");
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@orderdate", orderdate);
                command.Parameters.AddWithValue("@empid", empid);
                command.Parameters.AddWithValue("@custid", custid);
                command.Parameters.AddWithValue("@packid", packid);
                command.Parameters.AddWithValue("@total", total);
                command.Parameters.AddWithValue("@statorder", statorder);
                command.Parameters.AddWithValue("@statpayment", statpayment);
                int count = command.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Your Order Data Has Been Succsess Added");
                    // reset textbox
                    dateTimePicker1.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    textBox1.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to insert new data order, Please try again!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public insertdata()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            insertkedb();
        }

        private void InsertData_Load(object sender, EventArgs e)
        {
            isiinsert();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            HomePage mainform = new HomePage();
            mainform.Show();
        }
    }
}
