using Lab3.Context;
using System;
using System.Collections.Generic;

namespace Lab3.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiContext _context;
        private Dictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork(ApiContext context)
        {
            _context = context;
        }

        public IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class, new()
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<Type, object>();
            }

            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type))
            {
                _repositories[type] = new Repository<TEntity>(_context);
            }

            return (IRepository<TEntity>)_repositories[type];
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _repositories?.Clear();
                    _context.Dispose();
                }
            }

            _disposed = true;
        }
    }
}
