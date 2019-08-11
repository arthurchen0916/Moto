using Moto.Common.Entities;
using System.Collections.Generic;

namespace Moto.Common.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> QueryCustomerBySql(string sql, params object[] parameters);
    }
}