using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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

        public Transaction Transfer(Account source, Account destiny, double value)
        {
                            
            // Source
            if (source == null)
                throw new ArgumentException("Parameter source cannot be null");

            if (new AccountExistsSpecification().IsSatisfiedBy(source))
                throw new Exception("Source account not exists");

            if (new AccountIsNotANegativeValue().IsSatisfiedBy(source))
                throw new Exception("Source account don't have value enough");

            // Destiny
            if (destiny == null)
                throw new ArgumentException("Parameter source cannot be null");

            if (new AccountExistsSpecification().IsSatisfiedBy(destiny))
                throw new Exception("Destiny account not exists");

            // Value
            if(value <= 0)
                throw new Exception("The value should be greater than zero");


            using (var transScope = new TransactionScope())
            {
                source.Debit(value);
                destiny.Credit(value);

                var transaction = new Transaction(source, destiny, value);

                AccountRepository.Save(source);
                AccountRepository.Save(destiny);
                BankStatementRepository.RegisterTransaction(transaction);
                transScope.Complete();

                return transaction;
            }  
                      
        }

    }
}
