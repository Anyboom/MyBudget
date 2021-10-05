using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyBudget.Models;
using MyBudget.Services;

namespace MyBudget
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string Name = NameTextBox.Text,
                   Password = PassTextBox.Text,
                   RPassword = RPassTextBox.Text;

            if (String.IsNullOrEmpty(Name)
             || String.IsNullOrEmpty(Password)
             || String.IsNullOrEmpty(RPassword))
            {
                MessageService.ShowError("Нужно что-нибудь ввести.");
                return;
            }

            if(Password != RPassword)
            {
                MessageService.ShowError("Вы неправильно ввели пароль.");
                return;
            }

            using(MainContext db = new MainContext())
            {
                if(db.Accounts.Where(c => c.Name == Name).Any())
                {
                    MessageService.ShowWarn("Данный аккаунт с таким именем уже есть !");
                    return;
                }

                db.Accounts.Add(new Account()
                {
                    Name = Name,
                    Password = MD5Service.Create(Password),
                    CreatedAt = DateTime.Now
                });

                db.SaveChanges();
            }

            MessageService.ShowInfo("Вы успешно зарегистрировались !");

            Close();
        }
    }
}
