using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DojoTDD.Domain.Dojo_2.Services.Helpers;
using DojoTDD.Domain.Dojo_2.Services.Specifications;
using DojoTDD.Domain.Entities;
using DojoTDD.Domain.Repositories;
using DojoTDD.Domain.Services.Specifications;
using Transaction = DojoTDD.Domain.Entities.Transaction;

namespace DojoTDD.Domain.Services
{
    public class AccountService : IAccountService
    {
        public IAccountRepository AccountRepository { get; set; }

        public IBankStatementRepository BankStatementRepository { get; set; }

        public AccountService(IAccountRepository accountRepository, IBankStatementRepository bankStatementRepository)
        {
            AccountRepository = accountRepository;
            BankStatementRepository = bankStatementRepository;
        }

        public Transaction Transfer(Account accountToDebit, Account accountToCredit, double valueToTransfer)
        {
            ValidateTransfer(accountToDebit, accountToCredit, valueToTransfer);

            using (var transScope = new TransactionScope())
            {
                accountToDebit.Debit(valueToTransfer);
                accountToCredit.Credit(valueToTransfer);

                var transaction = new Transaction(accountToDebit, accountToCredit, valueToTransfer);

                AccountRepository.Save(accountToDebit);
                AccountRepository.Save(accountToCredit);
                BankStatementRepository.RegisterTransaction(transaction);
                transScope.Complete();

                return transaction;
            }  
                      
        }

        private static void ValidateTransfer(Account accountToDebit, Account accountToCredit, double valueToTransfer)
        {
            if (!accountToDebit.IsPossibleDebit()) throw new Exception("This account cannot be debit");
            if (!accountToCredit.IsPossibleCredit()) throw new Exception("This account cannot be credit");
            if (!valueToTransfer.ValueIsValidToTransfer()) throw new Exception("The value should be greater than zero");
        }
        

    }
}
