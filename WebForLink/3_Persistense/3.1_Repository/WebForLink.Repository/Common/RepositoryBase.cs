using System;
using System.Linq;

namespace WebForLink.Repository.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        //public DataContext Context
        //{
        //    get;
        //    set;
        //}
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Select()
        {
            throw new NotImplementedException();
        }

        public T Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //if (_context != null)
            //{
            //    _context.Dispose();
            //}
            GC.SuppressFinalize(this);
        }
    }
}
