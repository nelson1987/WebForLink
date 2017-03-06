﻿using System;
using System.Linq;

namespace WebForLink.Repository.Common
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Select();
        TEntity Select(TEntity entity);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
