using System;
using System.ComponentModel.DataAnnotations;

namespace WebForLink.ApplicationService.Interfaces
{
    public interface IAppService<TEntity> : IDisposable
        where TEntity : class
    {
        void BeginTransaction();
        void Commit();
        //TEntity Get(int id, bool @readonly = false);
        //TEntity Get(string id, bool @readonly = false);
        //TEntity GetAllReferences(int id, bool @readonly = false);
        //IEnumerable<TEntity> All(bool @readonly = false);
        //IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false);
    }
}
