using MyBudget.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Models
{
    class Transaction
    {
        public int Id { get; set; }
        public long Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public Status Status { get; set; }
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public Category Category { get; set; }
    }
}
