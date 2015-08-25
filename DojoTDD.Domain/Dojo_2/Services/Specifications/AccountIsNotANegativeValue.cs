using DojoTDD.Domain.Dojo_2.Entities;
using DojoTDD.Domain.Dojo_2.Interfaces.Specifications;

namespace DojoTDD.Domain.Dojo_2.Services.Specifications
{
    public class AccountIsNotANegativeValue : ISpecification<Account>
    {
        public bool IsSatisfiedBy(Account obj)
        {
            return obj.Value > 0;
        }
    }
}
