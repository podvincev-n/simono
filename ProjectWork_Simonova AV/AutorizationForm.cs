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
    public partial class AvtorizationForm : Form
    {
        public AvtorizationForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width,58);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text; // переменная для логина, получаем данные от пользователя
            string passwordUser = passField.Text;// переменная для пароля

            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userlogin AND `password` = @userpass", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginUser;

            command.Parameters.Add("@userpass", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;  // выполнение команды к БД
            adapter.Fill(table); //заполнение таблицу данными, которые получили от пользователя

            if (table.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                foreach (DataRow row in table.Rows)
                {
                    Program.ID_USER = Convert.ToInt32(row["id_user"]);
                }

                this.Hide();
                SpendControlForm spendcontrolform = new SpendControlForm();
                spendcontrolform.Show();
            }
            else
                MessageBox.Show("Некорректный логин/пароль");

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e) // закрытие формы 
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;  // класс для координат
        private void panel1_MouseMove(object sender, MouseEventArgs e) // метод для перемещения формы 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

     

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SpendControlForm spendcontrolform = new SpendControlForm();
            spendcontrolform.Show();
        }

        private void AddUser(object sender, EventArgs e)
        {
            this.Hide();
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        private void AvtorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void AvtorizationForm_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
