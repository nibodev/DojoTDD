using DojoTDD.Domain.Dojo_2.Entities;

namespace DojoTDD.Domain.Dojo_2.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        void Save(Account account);
    }
}
