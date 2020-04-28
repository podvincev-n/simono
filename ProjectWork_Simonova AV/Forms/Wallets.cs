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

        public Wallets()
        {
            InitializeComponent();

            this.walletList.View = System.Windows.Forms.View.Details;
            walletList.FullRowSelect = true;
            ListViewExtender extender = new ListViewExtender(walletList);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(2);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;

            extender.AddColumn(buttonAction);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddWallet addwallet = new AddWallet();
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
                    item.SubItems.Add("Добавить");
                }
            }
        }

        private void Wallets_Load(object sender, EventArgs e)
        {
           
        }
    }
}
