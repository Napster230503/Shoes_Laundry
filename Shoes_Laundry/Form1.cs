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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3306;database=shoes_laundry;uid=root;password=;";
            MySqlConnection db_con = new MySqlConnection(connectionString);
            db_con.Open();
            // Check if the username and password fields are empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(this, "Please enter your username and password corectly!!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                // Set focus to the first empty field
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtUsername.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtPassword.Focus();
                }

                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FPassword mainform = new FPassword();
            mainform.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            CreateNew mainform = new CreateNew();
            mainform.ShowDialog();
        }
    }
}
