using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWork_Simonova_AV.Forms;

namespace ProjectWork_Simonova_AV
{
    public partial class SpendControlForm : Form
    {
        public SpendControlForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            AddSpend addspend = new AddSpend();
            addspend.Show();
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
            Forms.Wallets wallets = new Forms.Wallets();
            wallets.Show();
        }

        private void SpendControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
