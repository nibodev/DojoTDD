using DojoTDD.Domain.Dojo_2.Entities;

namespace DojoTDD.Domain.Dojo_2.Interfaces.Services
{
    public interface IAccountService
    {
        Transaction Transfer(Account accountToDebit, Account accountToCredit, double valueToTransfer);
    }
}