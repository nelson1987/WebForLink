using System;
using System.Linq;

namespace WebForLink.Domain.Interfaces.Repository.Common
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Select();
        TEntity Select(TEntity entity);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
