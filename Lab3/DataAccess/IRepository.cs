using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Lab3.DataAccess
{
    public interface IRepository<TEntity>
            where TEntity : class
    {
        IQueryable<TEntity> Get();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        TEntity Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void Remove(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
    }
}
