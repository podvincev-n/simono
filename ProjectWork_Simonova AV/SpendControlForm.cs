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
using ProjectWork_Simonova_AV.Forms;
using System.Globalization;

namespace ProjectWork_Simonova_AV
{
    public partial class SpendControlForm : Form
    {
        DataTable datepoints = new DataTable();

        int minIntervalDays = 99;

        int userWalletsSum = 0;

        int todaySpend = 0;

        public SpendControlForm()
        {
            InitializeComponent();

            CalculateLimit();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadDatePounts()
        {
            if (datepoints.Rows.Count == 0)
            {
                DataBase database = new DataBase();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `date_points` WHERE `id_user` = @iduser", database.getConnection()); // для безопасноти делаем заглушку

                command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;

                adapter.SelectCommand = command;  // выполнение команды к БД
                adapter.Fill(datepoints); //заполнение таблицу данными, которые получили от пользователя
            }
        }

        private void GetMinIntervalDays()
        {
            DateTime thisDay = DateTime.Today;

            if (datepoints.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                foreach (DataRow row in datepoints.Rows)
                {
                    int day = Convert.ToInt32(row["day"]);
                    int month = (thisDay.Day > day) ? thisDay.Month + 1 : thisDay.Month;
                    int year = thisDay.Year;
                    if (month > 12)
                    {
                        month = 1;
                        year = year + 1;
                    }

                    DateTime datepoint = new DateTime(year, month, day);
                    double intervalDays = (datepoint - thisDay).TotalDays + 1;

                    minIntervalDays = Math.Min(minIntervalDays, Convert.ToInt32(intervalDays));
                }
            }
        }

        private void LoadWalletSum()
        {
            DataBase database = new DataBase();

            DataTable wallets = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(sum), 0) as sum FROM `wallets` WHERE `id_user` = @iduser", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;

            adapter.SelectCommand = command;  // выполнение команды к БД
            adapter.Fill(wallets); //заполнение таблицу данными, которые получили от пользователя

            if (wallets.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                foreach (DataRow row in wallets.Rows)
                {
                    userWalletsSum = Convert.ToInt32(row["sum"]);
                }
            }
        }

        private void LoadTodaySpend()
        {
            DataBase database = new DataBase();

            DataTable spends = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(sum), 0) as sum FROM `spends` WHERE `id_user` = @iduser AND `date` = @date", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");

            adapter.SelectCommand = command;  // выполнение команды к БД
            adapter.Fill(spends); //заполнение таблицу данными, которые получили от пользователя

            if (spends.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                foreach (DataRow row in spends.Rows)
                {
                    todaySpend = Convert.ToInt32(row["sum"]);
                }
            }
        }

        public void CalculateLimit() // расчет ежедневного лимита
        {
            LoadDatePounts();

            GetMinIntervalDays();

            LoadWalletSum();

            LoadTodaySpend();

            int limit = Convert.ToInt32((userWalletsSum + todaySpend) / minIntervalDays);

            todayLimit.Text = limit.ToString();

            todaySpendSum.Text = todaySpend.ToString();

            int balance = limit - todaySpend;

            todaybalance.Text = balance.ToString();
            
            if (balance < 0)
            {
                richStatus.Text = "Транжира";
            } else if (balance < (limit / 2))
            {
                richStatus.Text = "В плане";
            } else
            {
                richStatus.Text = "Экономничка";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpendControlForm spendcontrolform = new SpendControlForm();
            spendcontrolform.Show();
        }

        private void AddSpend_Click(object sender, EventArgs e)
        {
            AddSpend testDialog = new AddSpend();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            this.Hide();
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                CalculateLimit();
            }
            testDialog.Dispose();
            this.Show();
        }

        private void SpendStat_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpendStatistics spendstat = new SpendStatistics();
            spendstat.Show();
        }


        private void timer1_Tick(object sender, EventArgs e) // вывод текущей даты
        {
            string data = DateTime.Now.ToLongDateString();
            CurrentDate.Text = data;

        }

        private void Wallets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Wallets wallets = new Forms.Wallets(this);
            wallets.Show();
        }

        private void SpendControlForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
