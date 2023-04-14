using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using db_shoes;
using Shoes_Laundry.view;

namespace Shoes_Laundry
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            showdata mainform = new showdata();
            mainform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            insertdata mainform = new insertdata();
            mainform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Login mainform = new Login();
            mainform.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            dataemployee mainform = new dataemployee();
            mainform.Show();
        }
    }
}
