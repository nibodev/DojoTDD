using DojoTDD.Domain.Entities;
using DojoTDD.Domain.Services.Specifications;

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