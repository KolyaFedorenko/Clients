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
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=10.10.1.24;Initial Catalog=UPF;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public int id = 102;
        public int idplus = 123;
        public Form1()
        {
            InitializeComponent();
            ShowTable("SELECT * FROM Client WHERE ID BETWEEN " + id + " AND " + idplus);
            AddItems();
            rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            maxRowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
        }
        void ShowTable(string sql) // метод для отображения таблицы
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                clientsView.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        string SelectMaxID(string sql) // метод для получения количества записей в бд
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int reader = (int)command.ExecuteScalar();
                string maxId = reader.ToString();
                connection.Close();
                return maxId.ToString();
            }
        }
        void AddItems()
        {
            comboRows.Items.Add("10 записей");
            comboRows.Items.Add("50 записей");
            comboRows.Items.Add("200 записей");
            comboRows.Items.Add("Все записи");
        }
        void DBSearch(string text, string column) // метод для поиска по бд
        {
            if (text != "")
            {
                ShowTable("SELECT * FROM Client WHERE " + column + " LIKE '" + text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE " + column + " LIKE '" + text + "%'");
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            }
        }

        private void comboRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboRows.SelectedItem.ToString();
            if (selectedState == "10 записей")
            {
                ShowTable("SELECT TOP (10) * FROM Client");
            }
            if (selectedState == "50 записей")
            {
                ShowTable("SELECT TOP (50) * FROM Client");
            }
            if (selectedState == "200 записей")
            {
                ShowTable("SELECT TOP (200) * FROM Client");
            }
            if (selectedState == "Все записи")
            {
                ShowTable("SELECT * FROM Client");
            }
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            id = id - 22;
            idplus = idplus - 22;
            ShowTable("SELECT * FROM Client WHERE ID BETWEEN " + id + " AND " + idplus);
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            id = id + 22;
            idplus = idplus + 22;
            ShowTable("SELECT * FROM Client WHERE ID BETWEEN " + id + " AND " + idplus);
        }

        private void nameSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(nameSearch.Text, "FirstName");
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(lastNameSearch.Text, "LastName");
        }

        private void patronymicSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(patronymicSearch.Text, "Patronymic");
        }

        private void emailSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(emailSearch.Text, "Email");
        }

        private void phoneSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(phoneSearch.Text, "Phone");
        }
    }
}
    