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
            WalletForm temp = new WalletForm();
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

            if(e.Value is Status typeFormat)
            {
                e.Value = typeFormat switch
                {
                    Status.ADDED => "Добавлено",
                    Status.REMOVED => "Списано"
                };
            }

            if (e.Value is Category category)
            {
                e.Value = category switch
                {
                    Category.CAR => "Машина",
                    Category.CASH_WITHDRAWAL => "Выдача наличных",
                    Category.HEALTH => "Здоровье",
                    Category.TRANSLATION => "Перевод",
                    _ => "Нет"
                };
            }
        }

        private void UpdateTableButton_Click(object sender, EventArgs e)
        {
            using (MainContext db = new MainContext())
            {
                MainGrid.DataSource = db.Transactions.Where(c => c.Wallet.AccountId == Variables.AccountId && c.WalletId == (int) WalletComboBox.SelectedValue && c.CreatedAt.Month == (MonthComboBox.SelectedIndex + 1)).ToList();

                long total = db.Transactions.Where(c => c.Wallet.AccountId == Variables.AccountId && c.WalletId == (int)WalletComboBox.SelectedValue && c.Status == Status.ADDED).Sum(c => c.Total),
                     removed = db.Transactions.Where(c => c.Wallet.AccountId == Variables.AccountId && c.WalletId == (int)WalletComboBox.SelectedValue && c.Status == Status.REMOVED).Sum(c => c.Total);

                TotalWalletValue.Text = $"{(total - removed)} р.";
            }
        }

        private void MainGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MainGrid.Columns["Id"].HeaderText = "ИД";
            MainGrid.Columns["Total"].HeaderText = "СУММА";
            MainGrid.Columns["Status"].HeaderText = "СТАТУС";
            MainGrid.Columns["CreatedAt"].HeaderText = "ДАТА";
            MainGrid.Columns["Category"].HeaderText = "КАТЕГОРИЯ";

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
