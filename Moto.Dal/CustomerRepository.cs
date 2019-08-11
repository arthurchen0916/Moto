using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal.Base;
using System.Collections.Generic;

namespace Moto.Dal
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository()
        {
        }

        public IEnumerable<Customer> QueryCustomerBySql(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<Customer>(sql, parameters);
        }
    }
}