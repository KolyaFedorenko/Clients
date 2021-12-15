using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients
{
    public partial class AdminForm : Form
    {
        public string connectionString = "Data Source=10.10.1.24;Initial Catalog=UPF;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public AdminForm()
        {
            InitializeComponent();
            ShowTable();
        }
        void ShowTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT *  FROM Client";
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                clientsView.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
    }
}
    