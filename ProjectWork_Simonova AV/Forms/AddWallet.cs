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
    public partial class AddWallet : Form
    {
        private Wallets parentForm;

        public AddWallet(Wallets parentForm)
        {
            this.parentForm = parentForm;

            InitializeComponent();
        }

        private void AddWalletButton_Click(object sender, EventArgs e)
        {
            

            string namewallet = walletName.Text;
            int walletSum = Decimal.ToInt32(this.walletSum.Value);

            

            DataBase database = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `wallets` (`name`, `sum`, `id_user`) VALUES (@name, @sum, @iduser)", database.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namewallet;
            command.Parameters.Add("@sum", MySqlDbType.Int32).Value = walletSum;
            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = Program.ID_USER;


            database.openConnection();

            if (command.ExecuteNonQuery() == 1) // если команда на заполнение данных выполнена успешно
                MessageBox.Show("Кошелек добавлен");
            else
                MessageBox.Show("Кошелек не добавлен");

            this.Dispose();
            parentForm.Show();
            parentForm.UpdateForm();
        }

        private void CancelSpendAdd_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parentForm.Show();
        }

        private void AddWallet_Load(object sender, EventArgs e)
        {

        }
    }
}
