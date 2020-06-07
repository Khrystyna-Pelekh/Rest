using System;

namespace Lab3.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class, new();

        int SaveChanges();
    }
}
