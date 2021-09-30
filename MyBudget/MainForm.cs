using Microsoft.EntityFrameworkCore;

using MyBudget.Dialogs;
using MyBudget.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MonthComboBox.SelectedIndex = 0;
        
            using(MainContext db = new MainContext())
            {
                WalletComboBox.DataSource = db.Accounts.Include(c => c.Wallets).Where(c => c.Id == Variables.AccountId).First().Wallets;
                WalletComboBox.DisplayMember = "Name";
                WalletComboBox.ValueMember = "Id";

            }
        }

        private void WalletMenuItem_Click(object sender, EventArgs e)
        {
            WalletForm temp = new WalletForm();
            temp.ShowDialog();
        }
    }
}
