using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    class Wallet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public Wallet()
        {
            Transactions = new List<Transaction>();
        }
    }
}
