using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoTDD.Domain.Entities;

namespace DojoTDD.Domain.Services.Specifications
{
    public class AccountExistsSpecification : ISpecification<Account>
    {
        public bool IsSatisfiedBy(Account obj)
        {
            return obj.Number > 0;
        }
    }
}
