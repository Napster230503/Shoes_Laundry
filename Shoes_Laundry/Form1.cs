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
            this.Hide();
            HomePage mainform = new HomePage();
            if((txtUsername.Text =="admin") && (txtPassword.Text == "admin1"))
            {
                mainform.Show();
            }
            else
            {
                string text = "Username/Password yang anda masukan SALAH";
                MessageBox.Show(text);
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Show();
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
