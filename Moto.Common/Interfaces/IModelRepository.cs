using Moto.Common.Entities;
using System.Collections.Generic;

namespace Moto.Common.Interfaces
{
    public interface IModelRepository : IRepository<Model>
    {
        IEnumerable<int> QueryYearBySql(string sql);

        IEnumerable<Model> QueryModelBySql(string sql, params object[] parameters);
    }
}