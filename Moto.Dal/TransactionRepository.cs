using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal.Base;
using System.Collections.Generic;

namespace Moto.Dal
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository()
        {
        }

        public IEnumerable<Transaction> QueryTransactionBySql(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<Transaction>(sql, parameters);
        }
    }
}