using MyBudget.Models;
using MyBudget.Services;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App.Instance.MainForm = new LoginForm();

            using (MainContext db = new MainContext())
            {
                if (db.Database.CanConnect() == false)
                {
                    MessageService.ShowError("Отсутствует подключение к базе данных !");

                    Application.Exit();
                }
                else
                {
                    Application.Run(App.Instance);
                }
            }

        }
    }
}
