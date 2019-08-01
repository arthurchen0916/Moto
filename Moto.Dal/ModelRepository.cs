using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal.Base;
using System.Collections.Generic;

namespace Moto.Dal
{
    public class ModelRepository : BaseRepository<Model>,IModelRepository
    {
        public ModelRepository()
        {
        }
        public IEnumerable<Model> QueryYearBySql(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<Model>(sql, parameters);
        }
    }
}