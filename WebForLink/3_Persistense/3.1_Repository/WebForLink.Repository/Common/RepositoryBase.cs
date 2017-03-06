using System;
using System.Data.Entity;
using System.Linq;
using WebForLink.Data;

namespace WebForLink.Repository.Common
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable where TEntity : class
    {
        internal WebForLinkContexto _context;
        internal DbSet<TEntity> _dbSet;

        public RepositoryBase(WebForLinkContexto context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }
        public RepositoryBase()
        {
            this._context = new WebForLinkContexto();
            this._dbSet = new WebForLinkContexto().Set<TEntity>();
        }

        public TEntity Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public IQueryable<TEntity> Select()
        {
            return _dbSet;         
        }
        public TEntity Select(TEntity entity)
        {
            var pkey = _dbSet.Create().GetType().GetProperty("id").GetValue(entity);
            var set = _context.Set<TEntity>();
            TEntity attachedEntity = set.Find(pkey);
            return attachedEntity;
        }

        public void Update(TEntity entity)
        {
            var entry = _context.Entry<TEntity>(entity);
            var pkey = _dbSet.Create().GetType().GetProperty("id").GetValue(entity);

            if (entry.State == EntityState.Detached)
            {
                var set = _context.Set<TEntity>();
                TEntity attachedEntity = set.Find(pkey);  // access the key 
                if (attachedEntity != null)
                {
                    var attachedEntry = _context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified; // attach the entity 
                }
            }
        }
        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public void BeginTransaction()
        {
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context.Dispose();
        }

        public void Dispose()
        {
            _context.SaveChanges();
            _dbSet = null;
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
