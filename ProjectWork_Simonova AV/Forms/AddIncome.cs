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

namespace ProjectWork_Simonova_AV.Forms
{
    public partial class AddIncome : Form
    {
        int id_wallet;
        string name_wallet;
        Wallets form;

        public AddIncome(Wallets form, int id_wallet, string name_wallet)
        {
            this.id_wallet = id_wallet;

            this.form = form;

            InitializeComponent();

            this.label1.Text = name_wallet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `incomes` (`id_wallet`, `sum`, `id_user`, `date`) VALUES (@idwallet, @sum, @iduser, @date)", database.getConnection());

            command.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = id_wallet;
            command.Parameters.Add("@sum", MySqlDbType.Int32).Value = incomeSum.Value;
            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");


            database.openConnection();

            if (command.ExecuteNonQuery() == 1) // если команда на заполнение данных выполнена успешно
                MessageBox.Show("Кошелек добавлен");
            else
                MessageBox.Show("Кошелек не добавлен");

            MySqlCommand updcommand = new MySqlCommand("UPDATE `wallets` set `sum` = `sum` + @sum WHERE id_wallet = @idwallet", database.getConnection());

            updcommand.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = id_wallet;
            updcommand.Parameters.Add("@sum", MySqlDbType.Int32).Value = incomeSum.Value;
            updcommand.ExecuteNonQuery();

            this.Close();

            form.UpdateForm();
        }

        private void AddIncome_Load(object sender, EventArgs e)
        {

        }
    }
}
