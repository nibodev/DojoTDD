using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DojoTDD.Domain.Entities;

namespace DojoTDD.Domain.Repositories
{
    public interface IBankStatementRepository
    {
        void RegisterTransaction(Transaction transaction);
    }
}
