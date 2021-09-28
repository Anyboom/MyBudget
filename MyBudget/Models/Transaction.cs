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
        public int TypeTransactionId { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public int WalletId { get; set; }
        public Wallet Wallet { get; set; }
    }
}
