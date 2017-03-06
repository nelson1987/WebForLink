using System.Linq;

namespace WebForLink.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Select();
        T Select(int id);
        T Insert(T entity);
        T Update(T entity);
        T Delete(int id);
    }
}
