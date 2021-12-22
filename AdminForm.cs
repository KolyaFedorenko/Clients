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
        int sdoffset = 10;
        int sdfetch = 0;
        AddClientForm clientform;
        public AdminForm()
        {
            InitializeComponent();
            ShowTable("SELECT * FROM Client");
            comboRows.Items.Add("10 записей");
            comboRows.Items.Add("50 записей");
            comboRows.Items.Add("200 записей");
            comboRows.Items.Add("Все записи");
            comboRows.SelectedItem = "Все записи";
            RowsCount();
            nextPage.Enabled = false;
            prevPage.Enabled = false;
            maxRowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
        }

        /// <summary>
        /// Метод для отображения таблицы в соответствии с SQL-запросом SELECT, который принимается в качестве параметра
        /// </summary>
        /// <param name="sql"> SQL-запрос с SELECT </param>
        public void ShowTable(string sql) // метод для отображения таблицы
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
                    RowsCount();
                    maxRowsCount.Text = SelectMaxID("SELECT COUNT (*) FROM Client");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка");
            }

        }

        /// <summary>
        /// Метод для получения количества записей в базе данных, принимает SQL-запрос с SELECT в качестве параметра
        /// </summary>
        /// <param name="sql"> SQL-запрос с SELECT </param>
        /// <returns> Возвращает количество записей в таблице в соответствии с переданным SQL-запросом</returns>
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

        /// <summary>
        /// Метод для подсчета отображаемых строк в clientsView
        /// </summary>
        void RowsCount() // метод для подсчета строк в clientsView
        {
            int rows = clientsView.Rows.Count;
            rows = rows - 1;
            rowsCount.Text = rows.ToString();
        }

        /// <summary>
        /// Метод, объединяющий методы ShowTable() и RowsCount() для избежания дублирования кода
        /// </summary>
        /// <param name="sql"> SQL-запрос с SELECT </param>
        void SelectBy(string sql)
        {
            ShowTable(sql);
            RowsCount();
        }

        /// <summary>
        /// Вспомогательный метод для осуществления навигации, принимает значения смещения и выборки в качестве параметров
        /// </summary>
        /// <param name="offset"> Значение смещения </param>
        /// <param name="fetch"> Значение выборки </param>
        void SelectDigit(int offset, int fetch)
        {
            ShowTable("SELECT * FROM Client ORDER BY ID OFFSET " + offset.ToString() + " ROWS FETCH NEXT " + fetch.ToString() + " ROWS ONLY");
        }

        /// <summary>
        /// Метод для перехода к "следующей странице" clientsView, принимает значения смещения и выборки в качестве параметров
        /// </summary>
        /// <param name="offsetop"> Значение смещения </param>
        /// <param name="sdfetchop"> Значение выборки </param>
        void PaginationPlus(int offsetop, int sdfetchop)
        {
            sdoffset = sdoffset + offsetop;
            sdfetch = sdfetchop;
            SelectDigit(sdoffset, sdfetch);
        }

        /// <summary>
        /// Метод для перехода к "предыдущей странице" clientsView, принимает значения смещения и выборки в качестве параметров
        /// </summary>
        /// <param name="offsetop"> Значение смещения </param>
        /// <param name="sdfetchop"> Значение выборки </param>
        void PaginationMinus(int offsetop, int sdfetchop)
        {
            sdoffset = sdoffset - offsetop;
            sdfetch = sdfetchop;
            SelectDigit(sdoffset, sdfetch);
        }

        /// <summary>
        /// Метод для поиска записей в базе данных, принимает текст для поиска и столбец для поиска соответствий введенному тексту в качестве параметров
        /// </summary>
        /// <param name="text"> Текст, по которому производится поиск </param>
        /// <param name="column"> Название столбца, в котором производится поиск соответствий введенному тексту</param>
        void DBSearch(string text, string column) // метод для поиска по бд
        {
            if (text != "")
            {
                ShowTable("SELECT * FROM Client WHERE " + column + " LIKE '" + text + "%'");
                prevPage.Enabled = false;
                nextPage.Enabled = false;;
                RowsCount();
            }
            else
            {
                ShowTable("SELECT * FROM Client");
                prevPage.Enabled = true;
                nextPage.Enabled = true;
                RowsCount();
            }
        }

        /// <summary>
        /// Метод для обработки выбора значения в comboRows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Предыдущая страница"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Следующая страница"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (rowsCount.Text == "0")
	        {
                PaginationMinus(10, 10);
	        }
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле поиска по имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(nameSearch.Text, "FirstName");
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле поиска по фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastNameSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(lastNameSearch.Text, "LastName");
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле поиска по отчеству
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patronymicSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(patronymicSearch.Text, "Patronymic");
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле поиска по e-mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(emailSearch.Text, "Email");
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле поиска по телефону
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneSearch_TextChanged(object sender, EventArgs e)
        {
            DBSearch(phoneSearch.Text, "Phone");
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку сортировки клиентов по фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastNameSort_Click(object sender, EventArgs e)
        {
            ShowTable("SELECT * FROM Client ORDER BY Lastname");
            RowsCount();
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку фильрации по мужскому полу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maleFilter_Click(object sender, EventArgs e)
        {
            femaleFilter.Enabled = false;
            if (comboRows.SelectedItem == "10 записей")
            {
                ShowTable("SELECT TOP(10) * FROM Client WHERE GenderCode = 'м'");
                RowsCount();
            }
            if (comboRows.SelectedItem == "50 записей")
            {
                ShowTable("SELECT TOP(50) * FROM Client WHERE GenderCode = 'м'");
                RowsCount();
            }
            if (comboRows.SelectedItem == "200 записей")
            {
                ShowTable("SELECT TOP(200) * FROM Client WHERE GenderCode = 'м'");
                RowsCount();
            }
            if (comboRows.SelectedItem == "Все записи")
            {
                ShowTable("SELECT * FROM Client WHERE GenderCode = 'м'");
                RowsCount();
            }
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку фильрации по женскому полу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void femaleFilter_Click(object sender, EventArgs e)
        {
            maleFilter.Enabled = false;
            if (comboRows.SelectedItem == "10 записей")
            {
                ShowTable("SELECT TOP(10) * FROM Client WHERE GenderCode = 'ж'");
                RowsCount();
            }
            if (comboRows.SelectedItem == "50 записей")
            {
                ShowTable("SELECT TOP(50) * FROM Client WHERE GenderCode = 'ж'");
                RowsCount();
            }
            if (comboRows.SelectedItem == "200 записей")
            {
                ShowTable("SELECT TOP(200) * FROM Client WHERE GenderCode = 'ж'");
                RowsCount();
            }
            if (comboRows.SelectedItem == "Все записи")
            {
                ShowTable("SELECT * FROM Client WHERE GenderCode = 'ж'");
                RowsCount();
            }
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку сброса фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetFilter_Click(object sender, EventArgs e)
        {
            femaleFilter.Enabled = true;
            maleFilter.Enabled = true;
            if (comboRows.SelectedItem == "10 записей")
            {
                ShowTable("SELECT TOP(10) * FROM Client");
                RowsCount();
            }
            if (comboRows.SelectedItem == "50 записей")
            {
                ShowTable("SELECT TOP(50) * FROM Client");
                RowsCount();
            }
            if (comboRows.SelectedItem == "200 записей")
            {
                ShowTable("SELECT TOP(200) * FROM Client");
                RowsCount();
            }
            if (comboRows.SelectedItem == "Все записи")
            {
                ShowTable("SELECT * FROM Client");
                RowsCount();
            }
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Добавить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addClient_Click(object sender, EventArgs e)
        {
            clientform = new AddClientForm();
            clientform.options = "add";
            clientform.label1.Visible = false;
            clientform.idBox.Visible = false;
            clientform.Show();
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Редактировать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            clientform.userPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                clientform.userPhoto.Image = Image.FromFile(@"C:\Users\is12332\Source\Repos\Clients4\Resources\" + clientsView.Rows[rowindex].Cells[9].Value.ToString());
            }
            catch (Exception)
            {
                clientform.userPhoto.Image = Image.FromFile(@"C:\Users\is12332\Source\Repos\Clients4\Resources\Клиенты\default.png");
            }
            clientform.options = "edit";
            clientform.Show();
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Удалить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteClient_Click(object sender, EventArgs e)
        {
            int rowindex = clientsView.CurrentCell.RowIndex;
            string id = clientsView.Rows[rowindex].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Удалить клиента с ID " + id + "?", " Подтверждение удаления", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
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

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Посещения"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientVisits_Click(object sender, EventArgs e)
        {
            int rowindex = clientsView.CurrentCell.RowIndex;
            string id = clientsView.Rows[rowindex].Cells[0].Value.ToString();
            VisitsForm visits = new VisitsForm();
            visits.id = id;
            if (visitsLabel.Text != "0")
            {
                visits.Show();
            }
            else
            {
                MessageBox.Show("У данного клиента еще нет посещений");
            }
        }

        /// <summary>
        /// Метод для обработки нажатия на ячейки clientsView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int rowindex = clientsView.CurrentCell.RowIndex;
                string id = clientsView.Rows[rowindex].Cells[0].Value.ToString();
                string sql = "SELECT COUNT (StartTime) as Visit, Client.ID, FirstName FROM Client LEFT JOIN ClientService ON ClientService.ClientID = Client.ID Where Client.ID = " + id + " GROUP BY Client.ID, FirstName ORDER BY Visit DESC";
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                int reader = (int)command.ExecuteScalar();
                string clientVisits = reader.ToString();
                visitsLabel.Text = clientVisits;
                connection.Close();
            }
        }
    }
}
