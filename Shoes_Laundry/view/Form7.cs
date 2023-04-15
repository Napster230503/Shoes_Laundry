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
        private void employeetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = employeetable.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = employeetable.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = employeetable.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = employeetable.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = employeetable.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = employeetable.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = employeetable.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            HomePage mainform = new HomePage();
            mainform.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string id = (textBox1.Text);
            string konek = "Server=localhost;Database=shoes_laundry;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(konek);

            try
            {
                // Buka koneksi ke database
                connection.Open();

                // Buat perintah SQL untuk menghapus data dari tabel
                string sql = "DELETE FROM employee WHERE emp_id=@id";

                // Buat objek MySqlCommand dan tambahkan parameter
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                // Eksekusi perintah SQL
                int rowsAffected = command.ExecuteNonQuery();

                // Periksa apakah ada baris yang terpengaruh oleh operasi penghapusan
                if (rowsAffected > 0)
                {
                    // Tampilkan pesan berhasil
                    MessageBox.Show("Data berhasil dihapus dari database.");
                    Tampil();
                }
                else
                {
                    MessageBox.Show("Data dengan ID tersebut tidak ditemukan di database.");
                    Tampil();
                }

            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                // Tutup koneksi ke database
                connection.Close();
            }
        }

        private void dataemployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
