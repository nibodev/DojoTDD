using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoTDD.Domain.Entities
{
    public class Transaction
    {
        public Transaction(Account source, Account destiny, double value)
        {
            Source = source;
            Destiny = destiny;
            Value = value;
        }
        public Account Source { get; private set; }
        public Account Destiny { get; private set; }
        public double Value { get; private set; }
    }
}
