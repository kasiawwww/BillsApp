
using System;
using System.Collections.Generic;
using System.Text;

namespace BillsAppDatabase
{
    public class PaymentType
    {
        public string Name { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
