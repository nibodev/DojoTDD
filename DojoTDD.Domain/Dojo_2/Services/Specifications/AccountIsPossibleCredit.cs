﻿using DojoTDD.Domain.Dojo_2.Entities;
using DojoTDD.Domain.Dojo_2.Interfaces.Specifications;

namespace DojoTDD.Domain.Dojo_2.Services.Specifications
{
    public class AccountIsPossibleCredit : ISpecification<Account>
    {
        public bool IsSatisfiedBy(Account obj)
        {
            if (obj == null) return false;
            if (new AccountExistsSpecification().IsSatisfiedBy(obj)) return false;
            return true;

        }
    }
}