using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoTDD.Domain.Entities;
using DojoTDD.Domain.Services.Specifications;

namespace DojoTDD.Domain.Dojo_2.Services.Specifications
{
    public class AccountIsPossibleDebit : ISpecification<Account>
    {
        public bool IsSatisfiedBy(Account obj)
        {
            if (obj == null) return false;
            if (new AccountExistsSpecification().IsSatisfiedBy(obj)) return false;
            if (new AccountIsNotANegativeValue().IsSatisfiedBy(obj)) return false;
            return true;
        }
    }
}
