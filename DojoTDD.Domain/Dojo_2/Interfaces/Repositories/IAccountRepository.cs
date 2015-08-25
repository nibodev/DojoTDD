using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoTDD.Domain.Entities;

namespace DojoTDD.Domain.Repositories
{
    public interface IAccountRepository
    {
        void Save(Account account);
    }
}
