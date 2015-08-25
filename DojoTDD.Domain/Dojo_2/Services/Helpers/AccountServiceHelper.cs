using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoTDD.Domain.Dojo_2.Services.Specifications;
using DojoTDD.Domain.Entities;

namespace DojoTDD.Domain.Dojo_2.Services.Helpers
{
    public static class AccountServiceHelper
    {
        public static bool IsPossibleCredit(this Account account)
        {
            return new AccountIsPossibleCredit().IsSatisfiedBy(account);
        }

        public static bool IsPossibleDebit(this Account account)
        {
            return new AccountIsPossibleDebit().IsSatisfiedBy(account);
        }

        public static bool ValueIsValidToTransfer(this double value)
        {
            return value > 0;
        }
    }
}
