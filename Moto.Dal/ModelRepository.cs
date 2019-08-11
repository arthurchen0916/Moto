using Moto.Common.Entities;
using Moto.Common.Interfaces;
using Moto.Dal.Base;
using System.Collections.Generic;

namespace Moto.Dal
{
    public class ModelRepository : BaseRepository<Model>, IModelRepository
    {
        public ModelRepository()
        {
        }
        public IEnumerable<int> QueryYearBySql(string sql)
        {
            return _dbContext.Database.SqlQuery<int>(sql);
        }

        public IEnumerable<Model> QueryModelBySql(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<Model>(sql, parameters);
        }
    }
}