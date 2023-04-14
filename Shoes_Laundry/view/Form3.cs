using db_shoes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes_Laundry
{
    public partial class CreateNew : Form
    {
      Koneksi koneksi2 = new Koneksi();
        public CreateNew()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void Show(object sender, EventArgs e)
        {
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
                    string query = "INSERT INTO employee (emp_name, emp_address, emp_tlp, emp_mail, emp_username, emp_pass) VALUES (@name, @address, @telp, @mail,  @username, @password)";
                    try
                    {
                    MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=shoes_laundry(2);uid=root;password=;");
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@Telp", telp);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        int count = command.ExecuteNonQuery();
                        if (count > 0)
                        {
                            MessageBox.Show("Your Account Has Been Succsess Added");
                            // reset textbox
                            txtName.Text = "";
                            txtAddress.Text = "";
                            txtTelp.Text = "";
                            txtMail.Text = "";
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            Login mainform = new Login();
            mainform.Show();
        }
    }
}
