using System;
using System.Data.Entity;
using System.Linq;
using WebForLink.Data;
using WebForLink.Data.Config;
using WebForLink.Data.Interfaces;
using WebForLink.Domain.Interfaces.Repository.Common;

namespace WebForLink.Repository.Common
{
    public class RepositoryBase<TEntity, T>
    : IRepositoryBase<TEntity>, IDisposable
        where TEntity : class
        where T : BaseDbContext
    {
        private readonly IDbContext _context;
        private readonly IDbSet<TEntity> _dbSet;

        public RepositoryBase(WebForLinkContexto context)
        {
            this._context = context;
            _dbSet = _context.Set<TEntity>();

            //var contextManager =
            //    ServiceLocator.Current.GetInstance<IContextManager<ChMasterDataContext>>()
            //        as ContextManager<ChMasterDataContext>;

            //_dbContext = contextManager.GetContext();
            //_dbSet = _dbContext.Set<TEntity>();
        }
        public RepositoryBase()
        {
            this._context = new WebForLinkContexto();
            _dbSet = (DbSet<TEntity>)new WebForLinkContexto().Set<TEntity>();
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

        public void Dispose()
        {
            _context.SaveChanges();
            //_dbSet = null;
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (_context == null) return;
            _context.Dispose();
        }
    }
}
