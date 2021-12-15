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
        public int id = 102;
        public int idplus = 123;
        public AdminForm()
        {
            InitializeComponent();
            ShowTable("SELECT * FROM Client WHERE ID BETWEEN " + id + " AND " + idplus);
            AddItems();
            rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            maxRowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
        }
        void ShowTable(string sql)
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
        string SelectMaxID(string sql)
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
            if (nameSearch.Text != "")
            {
                ShowTable("SELECT * FROM Client WHERE FirstName LIKE '" + nameSearch.Text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE FirstName LIKE '" + nameSearch.Text + "%'");
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            }
        }

        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            if (lastNameSearch.Text != "")
            {
                ShowTable("SELECT * FROM Client WHERE LastName LIKE '" + lastNameSearch.Text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE Lastname LIKE '" + lastNameSearch.Text + "%'");
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            }
        }

        private void patronymicSearch_TextChanged(object sender, EventArgs e)
        {
            if (patronymicSearch.Text != "")
            {
                ShowTable("SELECT * FROM Client WHERE Patronymic LIKE '" + patronymicSearch.Text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE Patronymic LIKE '" + patronymicSearch.Text + "%'");
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            }
        }

        private void emailSearch_TextChanged(object sender, EventArgs e)
        {
            if (emailSearch.Text != "")
            {
                ShowTable("SELECT * FROM Client WHERE Email LIKE '" + emailSearch.Text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE Email LIKE '" + emailSearch.Text + "%'");
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            }
        }

        private void phoneSearch_TextChanged(object sender, EventArgs e)
        {
            if (phoneSearch.Text != "")
            {
                ShowTable("SELECT * FROM Client WHERE Phone LIKE '" + phoneSearch.Text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE Phone LIKE '" + phoneSearch.Text + "%'");
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
            }
        }
    }
}
    