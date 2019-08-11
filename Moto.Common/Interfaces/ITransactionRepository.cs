using Moto.Common.Entities;
using System.Collections.Generic;

namespace Moto.Common.Interfaces
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        IEnumerable<Transaction> QueryTransactionBySql(string sql, params object[] parameters);
    }
}