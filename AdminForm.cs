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
        int sdoffset = 10;
        int sdfetch = 0;
        AddClientForm clientform = new AddClientForm();
        public Form1()
        {
            InitializeComponent();
            ShowTable("SELECT * FROM Client");
            AddItems();
            comboRows.SelectedItem = "Все записи";
            RowsCount();
            nextPage.Enabled = false;
            prevPage.Enabled = false;
            maxRowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
        }
        void ShowTable(string sql) // метод для отображения таблицы
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка");
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
        void RowsCount() // метод для подсчета строк в dataGridView
        {
            int rows = clientsView.Rows.Count;
            rows = rows - 1;
            rowsCount.Text = rows.ToString();
        }
        void AddItems() // метод для добавления вариантов в comboBox
        {
            comboRows.Items.Add("10 записей");
            comboRows.Items.Add("50 записей");
            comboRows.Items.Add("200 записей");
            comboRows.Items.Add("Все записи");
        }
        void SelectBy(string sql)
        {
            ShowTable(sql);
            RowsCount();
        }
        void SelectDigit(int offset, int fetch)
        {
            ShowTable("SELECT * FROM Client ORDER BY ID OFFSET " + offset.ToString() + " ROWS FETCH NEXT " + fetch.ToString() + " ROWS ONLY");
        }
        void PaginationPlus(int offsetop, int sdfetchop)
        {
            sdoffset = sdoffset + offsetop;
            sdfetch = sdfetchop;
            SelectDigit(sdoffset, sdfetch);
        }

        void PaginationMinus(int offsetop, int sdfetchop)
        {
            sdoffset = sdoffset - offsetop;
            sdfetch = sdfetchop;
            SelectDigit(sdoffset, sdfetch);
        }

        void DBSearch(string text, string column) // метод для поиска по бд
        {
            if (text != "")
            {
                ShowTable("SELECT * FROM Client WHERE " + column + " LIKE '" + text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;
                //rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client WHERE " + column + " LIKE '" + text + "%'");
                RowsCount();
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                //rowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
                RowsCount();
            }
        }

        public void comboRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboRows.SelectedItem.ToString();
            if (selectedState == "10 записей")
            {
                SelectBy("SELECT TOP (10) * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
            }
            if (selectedState == "50 записей")
            {
                SelectBy("SELECT TOP (50) * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
            }
            if (selectedState == "200 записей")
            {
                SelectBy("SELECT TOP (200) * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
            }
            if (selectedState == "Все записи")
            {
                SelectBy("SELECT * FROM Client");
                nextPage.Enabled = false;
                prevPage.Enabled = false;
            }
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            if (comboRows.SelectedItem == "10 записей")
            {
                PaginationMinus(10, 10);
            }
            if (comboRows.SelectedItem == "50 записей")
            {
                PaginationMinus(50, 50);
            }
            if (comboRows.SelectedItem == "200 записей")
            {
                PaginationMinus(200, 200);
            }
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (comboRows.SelectedItem=="10 записей")
            {
                PaginationPlus(10, 10);
            }
            if (comboRows.SelectedItem == "50 записей")
            {
                PaginationPlus(50, 50);
            }
            if (comboRows.SelectedItem == "200 записей")
            {
                PaginationPlus(200, 200);
            }
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

        private void lastNameSort_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT * FROM Client ORDER BY Lastname");
            RowsCount();
        }

        private void maleFilter_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT * FROM Client WHERE GenderCode = 'м'");
            RowsCount();
        }

        private void femaleFilter_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT * FROM Client WHERE GenderCode = 'ж'");
            RowsCount();
        }

        private void resetFilter_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT * FROM Client");
            RowsCount();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            clientform = new AddClientForm();
            clientform.options = "add";
            clientform.label1.Visible = false;
            clientform.idBox.Visible = false;
            clientform.Show();
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            clientform = new AddClientForm();
            int rowindex = clientsView.CurrentCell.RowIndex;
            clientform.idBox.Text = clientsView.Rows[rowindex].Cells[0].Value.ToString();
            clientform.idBox.Enabled = false;
            clientform.firstnameBox.Text = clientsView.Rows[rowindex].Cells[1].Value.ToString();
            clientform.lastnameBox.Text = clientsView.Rows[rowindex].Cells[2].Value.ToString();
            clientform.patronymicBox.Text = clientsView.Rows[rowindex].Cells[3].Value.ToString();
            string date = clientsView.Rows[rowindex].Cells[4].Value.ToString();
            var parcedDate = DateTime.Parse(date);
            clientform.birthdayPicker.Value = parcedDate;
            clientform.emailBox.Text = clientsView.Rows[rowindex].Cells[6].Value.ToString();
            clientform.phoneBox.Text = clientsView.Rows[rowindex].Cells[7].Value.ToString();
            clientform.genderBox.SelectedItem = clientsView.Rows[rowindex].Cells[8].Value.ToString();
            clientform.options = "edit";
            clientform.Show();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            int rowindex = clientsView.CurrentCell.RowIndex;
            string id = clientsView.Rows[rowindex].Cells[0].Value.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Client WHERE ID='" + id + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            ShowTable("SELECT * FROM Client");
        }
    }
}
    