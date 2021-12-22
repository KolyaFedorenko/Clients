using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clients
{
    public partial class AddClientForm : Form
    {
        string connectionString = "Data Source=10.10.1.24;Initial Catalog=UPF;Persist Security Info=True;User ID=pro-41;Password=Pro_41student";
        public string date;
        public string gender;
        bool rightEmail;
        bool rightPhone;
        public string options;
        public string path;
        bool imageSelected = false;

        /// <summary>
        /// Метод для проверки корректности вводимых фамилии, имени и отчества с помощью регулярних выражений. Принимает текст элемента textBox в качестве параметра
        /// </summary>
        /// <param name="textbox"> Текст элемента textBox</param>
        /// <returns></returns>
        string checkFIO(string textbox)
        {
            if (Regex.IsMatch(textbox, @"[1\\2\\3\\4\\5\\6\\7\\8\\9\\0\\!\#\$\%\^\&\*\(\)\}\{\,\.\,\/\\?\'\+\=\:\;\№@]"))
            {
                textbox = Regex.Replace(textbox, @"[1\\2\\3\\4\\5\\6\\7\\8\\9\\0\\!\#\$\%\^\&\*\(\)\}\{\,\.\,\/\\?\'\+\=\:\;\№@]", "");
            }
            if (textbox.Length > 50)
            {
                MessageBox.Show("Длина данного поля не может быть больше 50");
                textbox = textbox.Substring(0, 50);
            }
            return textbox;
        }

        public AddClientForm()
        {
            InitializeComponent();
            genderBox.Items.Add("м");
            genderBox.Items.Add("ж");
        }

        /// <summary>
        /// Метод для выполнения запроса к базе данных SQL, в качестве параметра принимает INSERT, UPDATE или DELETE SQL-запрос
        /// </summary>
        /// <param name="sql"> INSERT, UPDATE или DELETE SQL-запрос</param>
        void SqlQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле имени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstnameBox_TextChanged(object sender, EventArgs e)
        {
            firstnameBox.Text = checkFIO(firstnameBox.Text);
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastnameBox_TextChanged(object sender, EventArgs e)
        {
            lastnameBox.Text = checkFIO(lastnameBox.Text);
        }

        /// <summary>
        /// Метод для обработки ввода текста в отчества 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void patronymicBox_TextChanged(object sender, EventArgs e)
        {
            patronymicBox.Text = checkFIO(patronymicBox.Text);
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле e-mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(emailBox.Text, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
            {
                rightEmail = true;
            }
            else
            {
                rightEmail = false;
            }
        }

        /// <summary>
        /// Метод для обработки ввода текста в поле телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(phoneBox.Text, @"^[0-9]+$") || Regex.IsMatch(phoneBox.Text, @"[+\-\(\)\ \@]"))
            {
                rightPhone = true;
            }
            else
            {
                phoneBox.Text = Regex.Replace(phoneBox.Text, @"^[a-zA-zа-яА-Я]+$", "");
                rightPhone = false;
            }
        }

        /// <summary>
        /// Метод для обработки выбора значения в birthdayPicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birthdayPicker_ValueChanged(object sender, EventArgs e)
        {
            date = birthdayPicker.Value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        ///  Метод для обработки выбора значения в genderBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = genderBox.SelectedItem.ToString();
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (options == "add")
            {
                if (rightPhone == true && rightEmail == true)
                {
                    try
                    {
                        if (imageSelected==false)
                        {
                            SqlQuery("INSERT INTO Client (FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode) VALUES ('" + firstnameBox.Text + "', '" + lastnameBox.Text + "', '" + patronymicBox.Text + "', '" + date + "', '" + DateTime.Today.ToString() + "', '" + emailBox.Text + "', '" + phoneBox.Text + "', '" + gender + "')");
                        }
                        else
                        {
                            SqlQuery("INSERT INTO Client (FirstName, LastName, Patronymic, Birthday, RegistrationDate, Email, Phone, GenderCode, PhotoPath) VALUES ('" + firstnameBox.Text + "', '" + lastnameBox.Text + "', '" + patronymicBox.Text + "', '" + date + "', '" + DateTime.Today.ToString() + "', '" + emailBox.Text + "', '" + phoneBox.Text + "', '" + gender + "', '" + "Клиенты\\" + path + "')");
                        }
                        MessageBox.Show("Добавление прошло успешно");
                    }
                    catch
                    {
                        MessageBox.Show("Возникла ошибка при добавлении, проверьте заполнение всех полей");
                    }

                }
                else
                {
                    MessageBox.Show("Вы ввели неверный телефон или почту");
                }
            }
            if (options == "edit")
            {
                try
                {
                    SqlQuery("UPDATE Client SET FirstName='" + firstnameBox.Text + "', LastName='" + lastnameBox.Text + "', Patronymic='" + patronymicBox.Text + "', Birthday='" + birthdayPicker.Value.ToString("yyyy-MM-dd") + "', Email='" + emailBox.Text + "', GenderCode='" + genderBox.SelectedItem.ToString() + "', PhotoPath='Клиенты\\"+path+"' WHERE ID='" + idBox.Text + "'");
                    MessageBox.Show("Данные были успешно обновлены");
                }
                catch
                {
                    MessageBox.Show("Возникла ошибка при редактировании");
                }
            }
        }

        /// <summary>
        /// Метод для обработки нажатия на кнопку "Добавить фото"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                userPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                    userPhoto.Image = Image.FromFile(ofd.FileName);
                File.Copy(ofd.FileName, Path.Combine(@"C:\Users\is12332\Source\Repos\Clients4\Resources\Клиенты\", Path.GetFileName(ofd.FileName)));
                path = Path.GetFileName(ofd.FileName);
                imageSelected = true;
                SaveFileDialog saveFile = new SaveFileDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Картинка с таким именем уже загружена.\nПереименуйте картинку и повторите попытку");
            }

        }
    }
}
