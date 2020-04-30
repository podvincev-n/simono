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

namespace ProjectWork_Simonova_AV.Forms
{
    public partial class DeleteWallet : Form
    {
        public DeleteWallet()
        {
            InitializeComponent();
        }

        private void DeleteWallet_Load(object sender, EventArgs e)
        {
            
        }

        private void notdelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
