using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWork_Simonova_AV
{
    public partial class AddSpend : Form
    {
        public AddSpend()
        {
            InitializeComponent();
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
            SpendControlForm spendcontrolform = new SpendControlForm();
            spendcontrolform.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
