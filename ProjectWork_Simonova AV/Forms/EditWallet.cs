using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWork_Simonova_AV.Forms
{
    public partial class EditWallet : Form
    {
        int idwallet;


        public EditWallet(int idwallet)
        {
            InitializeComponent();

            this.idwallet = idwallet;

            DataTable table = new DataTable();

            DataBase database = new DataBase();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `wallets` WHERE `id_wallet` = @idwallet", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = this.idwallet;

            adapter.SelectCommand = command;  // выполнение команды к БД
            adapter.Fill(table); //заполнение таблицу данными, которые получили от пользователя

            if (table.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                foreach (DataRow row in table.Rows)
                {
                    walletname.Text = row["name"].ToString();

                    sum.Text = row["sum"].ToString();
                }
            }
        }

        private void UpdateRow()
        {
            string walletname = this.walletname.Text;
            int sum = Decimal.ToInt32(this.sum.Value);

            DataBase database = new DataBase();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("UPDATE wallets SET name = @name, sum = @sum WHERE id_wallet = @idwallet", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@name", MySqlDbType.String).Value = walletname;
            command.Parameters.Add("@sum", MySqlDbType.Int32).Value = sum;
            command.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = idwallet;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1) // если команда на заполнение данных выполнена успешно
                MessageBox.Show("Кошелек отредактирован");
            else
                MessageBox.Show("Кошелек нихт отредактирован");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // save

            UpdateRow();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditWallet_Load(object sender, EventArgs e)
        {

        }
    }
}
