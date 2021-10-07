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

            using (MainContext db = new MainContext())
            {
                CategoryComboBox.DataSource = Enum.GetNames(typeof(Category)).Skip(1).ToList();
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            long total = Convert.ToInt64(TotalTextBox.Text);
            Status status = (AddRadioButton.Checked) ? Status.ADDED : Status.REMOVED;

            Category category = Category.NONE;

            if(status == Status.REMOVED)
            {
                category = (Category) Enum.Parse(typeof(Category), CategoryComboBox.SelectedValue.ToString());
            }

            using(MainContext db = new MainContext())
            {
                Transaction result = new Transaction()
                {
                    Total = total,
                    WalletId = walletId,
                    Status = status,
                    CreatedAt = DateTime.Now,
                    Category = category
                };

                db.Transactions.Add(result);
                db.SaveChanges();
            }

            Close();
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CategoryComboBox.Enabled = (sender as RadioButton).Checked == false;
        }

        private void CategoryComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string result = Enum.Parse<Category>(e.ListItem.ToString()) switch {
                Category.CAR => "Машина",
                Category.CASH_WITHDRAWAL => "Выдача наличных",
                Category.HEALTH => "Здоровье",
                Category.TRANSLATION => "Перевод"
            };

            e.Value = result;
        }
    }
}
