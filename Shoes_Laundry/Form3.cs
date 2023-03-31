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
                string name = txtName.Text.Trim();
                string address = txtAddress.Text.Trim();
                string telp = txtTelp.Text.Trim();
                string mail = txtMail.Text.Trim();                
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(telp) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in the above !!!");
                return;
            }
            else
            {
                string query = "INSERT INTO account (name, mail, BoD, gender, address, username, password) VALUES (@name, @mail, @BoD, @gender, @address, @username, @password)";
                try
                {

                    MySqlCommand command = new MySqlCommand(query);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@BoD", BoD);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Akun berhasil dibuat!");
                        // reset textbox
                        txtName.Text = "";
                        txtMail.Text = "";
                        txtTelp.Text = "";
                        boxGender.Text = "";
                        txtAddress.Text = "";
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to create your new account, Please try again!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
             
        }

        private void CreateNew_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
