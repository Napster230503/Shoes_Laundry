using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace db_shoes
{
    class Koneksi
    {
        string conectionstring = "Server=localhost;Database=shoes_laundry(2);Uid=root;Pwd=;";
        MySqlConnection kon;
        public void OpenCOnnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }
        public void CloseConnection()
        {
            kon.Close();
        }
        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }
        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();
            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }
    }
}
