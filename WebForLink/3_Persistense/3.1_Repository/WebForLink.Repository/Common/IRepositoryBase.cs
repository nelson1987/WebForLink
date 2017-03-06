using System;
using System.Linq;

namespace WebForLink.Repository.Common
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> Select();
        T Select(int id);
        T Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
