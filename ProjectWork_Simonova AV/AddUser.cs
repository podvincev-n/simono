using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectWork_Simonova_AV
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            UserNameField.Text = "Введите имя";
            UserNameField.ForeColor = Color.Gray;
            UserNameField.Text = "Введите имя";
            UserNameField.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvtorizationForm avtorizationform = new AvtorizationForm();
            avtorizationform.Show();
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void AddUser_Enter(object sender, EventArgs e)
        {

        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {

           if (UserNameField.Text == "Введите имя")
            { 
            UserNameField.Text = "";
            UserNameField.ForeColor = Color.Black;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //проверка на запонление полей

            if (UserNameField.Text == "Введите имя") 

            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (ExistUser())
                return;


          DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", database.getConnection());

            command.Parameters.Add("@login",MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = UserPassField.Text;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1) // если команда на заполнение данных выполнена успешно
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не был создан");


            database.closeConnection();
        }

        public Boolean ExistUser() // проверка на наличие пользователя в БД c таким же логином
        {
            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userlogin", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = UserNameField.Text;

            

            adapter.SelectCommand = command;  // выполнение команды к БД
            adapter.Fill(table); //заполнение таблицу данными, которые получили от пользователя

            if (table.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else
            return false;
            MessageBox.Show("Некорректный логин/пароль");
        }
    }
}
