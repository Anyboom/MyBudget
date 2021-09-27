
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    class MainContext : DbContext
    {
        public MainContext() : base(Settings.ConnectionString)
        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}
