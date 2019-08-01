using Moto.Common.Entities;
using System.Collections.Generic;

namespace Moto.Common.Interfaces
{
    public interface IModelRepository : IRepository<Model>
    {
        IEnumerable<Model> QueryYearBySql(string sql, params object[] parameters);
    }
}