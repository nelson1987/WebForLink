﻿using Microsoft.Practices.ServiceLocation;
using System;
using System.Data.Entity.Validation;
using WebForLink.ApplicationService.Interfaces.Common;
using WebForLink.Data.Interfaces;
using WebForLink.Domain.Validation;

namespace WebForLink.ApplicationService.Common
{
    public class AppService<TContext> : ITransactionAppService<TContext>
            where TContext : IDbContext, new()
    {
        private IUnitOfWork<TContext> _uow;

        public AppService()
        {
            ValidationResult = new ValidationResult();
        }

        protected ValidationResult ValidationResult { get; private set; }

        public virtual void BeginTransaction()
        {
            //_uow = ServiceLocator.Current.GetInstance<IUnitOfWork<TContext>>();
            _uow = new UnitOfWork()
            _uow.BeginTransaction();
        }

        public virtual void Commit()
        {
            try
            {
                _uow.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    ValidationResult.Add(
                        string.Format(
                            "A entidade do Tipo \"{0}\" no estado \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        ValidationResult.Add(string.Format("- Propriedade : \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
