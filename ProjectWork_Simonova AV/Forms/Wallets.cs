using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWork_Simonova_AV.Classes;
using MySql.Data.MySqlClient;

namespace ProjectWork_Simonova_AV.Forms
{
    public partial class Wallets : Form
    {
        DataTable table = new DataTable();

        private SpendControlForm parentForm;


        public Wallets(SpendControlForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            this.walletList.View = System.Windows.Forms.View.Details;
            walletList.FullRowSelect = true;
            ListViewExtender extender = new ListViewExtender(walletList);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(2);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            // extend 3nd column
            ListViewButtonColumn buttonAction3 = new ListViewButtonColumn(3);
            buttonAction3.Click += OnButtonActionClick3;
            buttonAction3.FixedWidth = true;

            // extend 4nd column
            ListViewButtonColumn buttonAction2 = new ListViewButtonColumn(4);
            buttonAction2.Click += OnButtonActionClick2;
            buttonAction2.FixedWidth = true;

            extender.AddColumn(buttonAction);
            extender.AddColumn(buttonAction2);
            extender.AddColumn(buttonAction3);

            UpdateForm();
        }

        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            ListView.SelectedIndexCollection sel = walletList.SelectedIndices;

            if (sel.Count == 1)
            {
                ListViewItem selItem = walletList.Items[sel[0]];

                AddIncome addincome = new AddIncome(
                    this,
                    Convert.ToInt32(table.Rows[selItem.Index]["id_wallet"]),
                    table.Rows[selItem.Index]["name"].ToString()
                );
                addincome.Show();
            }
        }

        /* private void deleteButton_Click(object sender, EventArgs e) // удаление объекта из листа
         {
             foreach (ListView row in ListView.SelectedIndexCollection)
             {
                 dataGridView1.Rows.Remove(row);
             }
         }

     */



        private void DeleteRow(int idwallet)
        {
            DataBase database = new DataBase();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("DELETE FROM wallets WHERE id_wallet = @idwallet", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@idwallet", MySqlDbType.Int32).Value = idwallet;

            database.openConnection();

            if (command.ExecuteNonQuery() == 1) // если команда на заполнение данных выполнена успешно
                MessageBox.Show("Кошелек удален");
            else
                MessageBox.Show("Кошелек нихт удален");
        }


        private void OnButtonActionClick2(object sender, ListViewColumnMouseEventArgs e) // удаление кошелька
        {
            ListView.SelectedIndexCollection sel = walletList.SelectedIndices;

            DeleteWallet testDialog = new DeleteWallet();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (sel.Count == 1)
                {
                    ListViewItem selItem = walletList.Items[sel[0]];
                    DeleteRow(Convert.ToInt32(table.Rows[selItem.Index]["id_wallet"]));
                }
            }
            testDialog.Dispose();
            UpdateForm();
        }

        private void OnButtonActionClick3(object sender, ListViewColumnMouseEventArgs e) // редактирвоане кошелька
        {
            ListView.SelectedIndexCollection sel = walletList.SelectedIndices;

            if (sel.Count == 1)
            {
                ListViewItem selItem = walletList.Items[sel[0]];

                EditWallet testDialog = new EditWallet(Convert.ToInt32(table.Rows[selItem.Index]["id_wallet"]));

                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    UpdateForm();
                }
                testDialog.Dispose();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWallet addwallet = new AddWallet(this);
            addwallet.Show();
        }

        private void walletList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateForm()
        {
            walletList.Items.Clear();

            table = new DataTable();

            DataBase database = new DataBase();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `wallets` WHERE `id_user` = @iduser", database.getConnection()); // для безопасноти делаем заглушку

            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;

            adapter.SelectCommand = command;  // выполнение команды к БД
            adapter.Fill(table); //заполнение таблицу данными, которые получили от пользователя

            if (table.Rows.Count > 0) //проверяем сколько записей в таблице соответствует тому, что ввел пользователь
            {
                foreach (DataRow row in table.Rows)
                {
                    ListViewItem item = walletList.Items.Add(row["name"].ToString());
                    item.SubItems.Add(row["sum"].ToString());
                    item.SubItems.Add("Добавить денег");
                    item.SubItems.Add("Редактировать");
                    item.SubItems.Add("Удалить");

                }
            }
        }

        private void Wallets_Load(object sender, EventArgs e)
        {
           
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.CalculateLimit();
            parentForm.Show();
        }
    }
}
