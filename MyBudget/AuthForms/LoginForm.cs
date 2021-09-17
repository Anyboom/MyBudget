using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            App.Instance.MainForm = new RegistrationForm();
            App.Instance.MainForm.Show();

            Close();
        }
    }
}
