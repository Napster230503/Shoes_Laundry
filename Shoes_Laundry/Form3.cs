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

namespace Shoes_Laundry
{
    public partial class CreateNew : Form
    {
        public CreateNew()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrt_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=shoes_laundry;uid=root;password=;";
            MySqlConnection db_con = new MySqlConnection(connectionString);
            db_con.Open();

            //Isian semua data            
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username dan password harus diisi!");
                    return;
                }
                string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                try
                {
                    OpenConnection();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Akun berhasil dibuat!");
                        // reset textbox
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Gagal membuat akun!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
             
        }
    }
}
