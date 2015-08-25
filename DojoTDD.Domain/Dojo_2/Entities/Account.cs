using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoTDD.Domain.Entities
{
    public class Account
    {
        public Account(int number, double startValue)
        {
            Number = number;
            Value = startValue;
        }

        public int Number { get; private set; }

        public double Value { get; private set; }

        public void Debit(double value)
        {
            if (value < 0)
                throw new Exception("Value cannot be negative");

            Value -= value;
        }

        public void Credit(double value)
        {
            if (value < 0)
                throw new Exception("Value cannot be negative");

            Value += value;
        }


    }
}
