using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Moto.Common.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        void Add(T brand);
        void Remove(T brand);
        void Update(T brand);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll();
        
    }
}