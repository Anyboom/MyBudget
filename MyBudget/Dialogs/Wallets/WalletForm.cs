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

namespace MyBudget.Dialogs
{
    public partial class WalletForm : Form
    {
        public WalletForm()
        {
            InitializeComponent();

        }

        private void WalletForm_Load(object sender, EventArgs e)
        {
            using(MainContext db = new MainContext())
            {
                MainList.DataSource = db.Wallets.Where(c => c.Account.Id == Variables.AccountId).ToList();
                MainList.DisplayMember = "Name";
                MainList.ValueMember = "Id";
            }
        }

        private void AddWalletMenu_Click(object sender, EventArgs e)
        {
            string name = MessageService.InputBox("Введите имя для нового кошелька:");

            using(MainContext db = new MainContext())
            {
                Wallet newWallet = new Wallet()
                {
                    Name = name
                };

                Account thisAccount = db.Accounts.Find(Variables.AccountId);
                thisAccount.Wallets.Add(newWallet);

                db.SaveChanges();

                MainList.DataSource = db.Wallets.Where(c => c.Account.Id == Variables.AccountId).ToList();
            }
        }

        private void MainList_Format(object sender, ListControlConvertEventArgs e)
        {
            Wallet temp = e.ListItem as Wallet;
            e.Value = $"{temp.Id} | {temp.Name}";
        }

        private void RemoveWalletMenu_Click(object sender, EventArgs e)
        {
            Wallet walletForRemove = MainList.SelectedItem as Wallet;

            DialogResult result = MessageBox.Show($"Вы точно собираетесь удалить кошелек {walletForRemove.Id} | {walletForRemove.Name} ?", Variables.TitleProject, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.No)
            {
                return;
            }

            using(MainContext db = new MainContext())
            {
                db.Wallets.Remove(walletForRemove);

                db.SaveChanges();

                MainList.DataSource = db.Wallets.Where(c => c.Account.Id == Variables.AccountId).ToList();
            }
        }

        private void EditWalletMenu_Click(object sender, EventArgs e)
        {
            string name = MessageService.InputBox("Введите новое имя для кошелька:");

            Wallet walletForEdit = MainList.SelectedItem as Wallet;

            walletForEdit.Name = name;

            using (MainContext db = new MainContext())
            {
                db.Wallets.Update(walletForEdit);

                db.SaveChanges();

                MainList.DataSource = db.Wallets.Where(c => c.Account.Id == Variables.AccountId).ToList();
            }
        }
    }
}
