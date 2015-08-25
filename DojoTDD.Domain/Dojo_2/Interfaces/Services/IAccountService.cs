using DojoTDD.Domain.Entities;

namespace DojoTDD.Domain.Services
{
    public interface IAccountService
    {
        Transaction Transfer(Account source, Account destiny, double value);
    }
}