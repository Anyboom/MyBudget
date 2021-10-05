﻿using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    class MainContext : DbContext
    {
        public MainContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Variables.ConnectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
