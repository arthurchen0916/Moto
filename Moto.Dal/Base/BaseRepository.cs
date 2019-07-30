using Moto.Common;
using Moto.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Moto.Dal.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal MotoContext _dbContext
        {
            get;
            set;
        }

        public BaseRepository()
        {
            _dbContext = new MotoContext();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().SingleOrDefault(x => x.id == id);
        }

        public void Add(T brand)
        {
            _dbContext.Set<T>().Add(brand);
            _dbContext.SaveChanges();
        }

        public void Remove(T brand)
        {
            _dbContext.Set<T>().Remove(brand);
            _dbContext.SaveChanges();
        }

        public void Update(T brand)
        {
            var entry = _dbContext.Entry<T>(brand);

            if (entry.State == EntityState.Detached)
            {
                var set = _dbContext.Set<T>();

                T attachedEntity = set.Find(brand.id);

                if (attachedEntity != null)
                {
                    var attachedEntry = _dbContext.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(brand);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate.Compile()).AsQueryable();
        }

        public IEnumerable<T> FindAll()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public IEnumerable<T> SqlQuery(string sql, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<T>(sql, parameters);
        }
    }
}