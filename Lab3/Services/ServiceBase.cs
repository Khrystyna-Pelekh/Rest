using Lab3.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Services
{
    public abstract class ServiceBase<TDto, TEntity>
         where TDto : class, new()
         where TEntity : class, new()
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected virtual IRepository<TEntity> Repository => UnitOfWork.GetRepository<TEntity>();

        protected ServiceBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
