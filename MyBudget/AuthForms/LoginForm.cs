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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            
        }

        private void RegLinkLabel_Click(object sender, EventArgs e)
        {
            Form tempForm = new RegistrationForm();

            tempForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Login = LoginTextBox.Text,
                   Password = PassTextBox.Text;

            if (String.IsNullOrEmpty(Name)
             || String.IsNullOrEmpty(Password))
            {
                MessageService.ShowError("Нужно что-нибудь ввести.");
                return;
            }

            using (MainContext db = new MainContext())
            {
                Account temp = db.Accounts.Where(c => c.Name == Login).FirstOrDefault();

                if (temp == null)
                {
                    MessageService.ShowWarn("Данного аккаунта с таким именем нет !");
                    return;
                }

                if(MD5Service.Create(Password) != temp.Password)
                {
                    MessageService.ShowWarn("Неправильный пароль.");
                    return;
                }

                Variables.AccountId = temp.Id;

                App.Instance.MainForm = new MainForm();
                App.Instance.MainForm.Show();

                Close();
            }
        }
    }
}
