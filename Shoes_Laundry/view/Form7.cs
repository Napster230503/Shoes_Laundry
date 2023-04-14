using db_shoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes_Laundry.view
{
    public partial class dataemployee : Form
    {
        Koneksi koneksi = new Koneksi();
        public dataemployee()
        {
            InitializeComponent();
        }
        public void Tampil()
        {
            employeetable.DataSource = koneksi.ShowData("select * from employee");
            employeetable.Columns[0].HeaderText = "Employee ID";
            employeetable.Columns[1].HeaderText = "Name";
            employeetable.Columns[2].HeaderText = "Address";
            employeetable.Columns[3].HeaderText = "Phone Number";
            employeetable.Columns[4].HeaderText = "Email";
            employeetable.Columns[5].HeaderText = "Username";
            employeetable.Columns[6].HeaderText = "Paswword";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
