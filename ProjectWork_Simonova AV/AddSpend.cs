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
using ProjectWork_Simonova_AV.Classes;

namespace ProjectWork_Simonova_AV
{
    public partial class AddSpend : Form
    {
        public AddSpend()
        {
            InitializeComponent();
            fillCategory();
            fillWallets();
        }

        private void CategorySpend_Click(object sender, EventArgs e)
        {

        }

        private void SpendCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelSpendAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillCategory() // заполняем комбобокс с названиями категорий
        {
            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `categories`", database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    ComboboxItem item = new ComboboxItem { Text = row["name"] as string, Value = row["id_category"].ToString() };
                    categoryList.Items.Add(item);
                }
            }           
        }

        private void fillWallets() // заполняем комбобокс с названиями кошельков
        {
            DataBase database = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `wallets` WHERE `id_user` = @iduser", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    walletList.Items.Add(new ComboboxItem { Text = (row["name"] as string) + " (" + row["sum"] + "руб.)", Value = row["id_wallet"].ToString() });
                }
            }
        }


        private void AddSpendButton_Click(object sender, EventArgs e) // добавление новой траты 
        {
            int categoryId = Convert.ToInt32((categoryList.SelectedItem as ComboboxItem).Value);
            int walletId = Convert.ToInt32((walletList.SelectedItem as ComboboxItem).Value);
            int spendSum = Convert.ToInt32(this.spendSum.Value);

            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `spends` (`id_category`, `sum`, `date`,`id_wallet`, `id_user`) VALUES (@idcategory, @sum, @date, @idwallet, @iduser)", database.getConnection());

            command.Parameters.Add("@idcategory", MySqlDbType.Int32).Value = categoryId;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");
            command.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = walletId ;
            command.Parameters.Add("@sum", MySqlDbType.Int32).Value = spendSum;
            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;


            database.openConnection();

            if (command.ExecuteNonQuery() == 1) // если команда на заполнение данных выполнена успешно
                MessageBox.Show("Трата добавлена");
            else
                MessageBox.Show("Трата не добавлена");

            MySqlCommand updcommand = new MySqlCommand("UPDATE `wallets` set `sum` = `sum` - @sum WHERE id_wallet = @idwallet", database.getConnection());

            updcommand.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = walletId;
            updcommand.Parameters.Add("@sum", MySqlDbType.Int32).Value = spendSum;
            updcommand.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
        

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
