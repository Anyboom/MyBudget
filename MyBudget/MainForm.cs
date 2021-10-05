using Microsoft.EntityFrameworkCore;

using MyBudget.Dialogs;
using MyBudget.Enums;
using MyBudget.Models;
using MyBudget.Services;

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

            MonthComboBox.SelectedIndex = DateTime.Now.Month - 1;

            using (MainContext db = new MainContext())
            {
                WalletComboBox.DataSource = db.Wallets.Where(c => c.AccountId == Variables.AccountId).ToList();
            }

            WalletComboBox.DisplayMember = "Name";
            WalletComboBox.ValueMember = "Id";
        }

        private void WalletMenuItem_Click(object sender, EventArgs e)
        {
            AddWalletForm temp = new AddWalletForm();
            DialogResult result = temp.ShowDialog();

            using MainContext db = new MainContext();

            WalletComboBox.DataSource = db.Wallets.Where(c => c.AccountId == Variables.AccountId).ToList();
        }

        private void MainGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime timeFormat)
            {
                e.Value = timeFormat.ToString("g");
            }

            if(e.Value is TypeTransaction typeFormat)
            {
                e.Value = typeFormat switch
                {
                    TypeTransaction.ADDED => "Добавлено",
                    TypeTransaction.REMOVED => "Списано"
                };
            }
        }

        private void UpdateTableButton_Click(object sender, EventArgs e)
        {
            using (MainContext db = new MainContext())
            {
                MainGrid.DataSource = db.Transactions.Where(c => c.Wallet.AccountId == Variables.AccountId && c.WalletId == (int) WalletComboBox.SelectedValue && c.CreatedAt.Month == (MonthComboBox.SelectedIndex + 1)).ToList();

                long total = db.Transactions.Where(c => c.Wallet.AccountId == Variables.AccountId && c.WalletId == (int)WalletComboBox.SelectedValue && c.TypeTransaction == TypeTransaction.ADDED).Sum(c => c.Total),
                     removed = db.Transactions.Where(c => c.Wallet.AccountId == Variables.AccountId && c.WalletId == (int)WalletComboBox.SelectedValue && c.TypeTransaction == TypeTransaction.REMOVED).Sum(c => c.Total);

                TotalWalletValue.Text = $"{(total - removed)} р.";
            }
        }

        private void MainGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainGrid.Columns["Id"].HeaderText = "ИД";
            MainGrid.Columns["Total"].HeaderText = "СУММА";
            MainGrid.Columns["TypeTransaction"].HeaderText = "СТАТУС";
            MainGrid.Columns["CreatedAt"].HeaderText = "ДАТА";

            MainGrid.Columns["WalletId"].Visible = false;
            MainGrid.Columns["Wallet"].Visible = false;
        }

        private void AddTransactionMenuItem_Click(object sender, EventArgs e)
        {
            AddTransactionForm temp = new AddTransactionForm((int)WalletComboBox.SelectedValue);
            temp.ShowDialog();
        }
    }
}
