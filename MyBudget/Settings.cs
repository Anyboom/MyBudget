﻿using MyBudget.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget
{
    class Settings
    {
        public static string TitleProject = "Учет бюджета";
        public static string ConnectionString = @"Data Source=DESKTOP-J758LQV\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=MyBudget;";
        public static Account ThisAccount = null;
    }
}
