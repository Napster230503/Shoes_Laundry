using db_shoes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Shoes_Laundry
{
    public partial class FPassword : Form
    {
        Koneksi koneksi2 = new Koneksi();
        public FPassword()
        {
            InitializeComponent();
        }

        public void update(object sender, EventArgs e)
        {
            string username = txtUserForget.Text.Trim();
            string password = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in the above !!!");
                return;
            }
            else
            {
                string query = "UPDATE employee SET emp_pass = @password where emp_name = @username";
                try
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=shoes_laundry(2);uid=root;password=;");
                        conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                    int count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Your Account Has Been Update");
                        // reset textbox
                        txtUserForget.Text = "";
                        txtNewPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update, Please try again!!");
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

        

    }
}
