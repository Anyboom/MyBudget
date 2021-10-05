using MyBudget.Enums;
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

namespace MyBudget.Dialogs
{
    public partial class AddTransactionForm : Form
    {
        private readonly int walletId;
        public AddTransactionForm(int WalletId)
        {
            InitializeComponent();

            this.walletId = WalletId;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            long total = Convert.ToInt64(TotalTextBox.Text);
            TypeTransaction typeTransaction = (AddRadioButton.Checked) ? TypeTransaction.ADDED : TypeTransaction.REMOVED;

            using(MainContext db = new MainContext())
            {
                Transaction result = new Transaction()
                {
                    Total = total,
                    WalletId = walletId,
                    TypeTransaction = typeTransaction,
                    CreatedAt = DateTime.Now
                };

                db.Transactions.Add(result);
                db.SaveChanges();
            }

            Close();
        }
    }
}
