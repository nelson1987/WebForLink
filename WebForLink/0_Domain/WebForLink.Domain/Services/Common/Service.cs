using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WebForLink.Domain.Interfaces.Repository.Common;
using WebForLink.Domain.Interfaces.Services.Common;
using WebForLink.Domain.Interfaces.Validation;
using WebForLink.Domain.Validation;

namespace WebForLink.Domain.Services.Common
{
    public class Service<TEntity> : IService<TEntity>
            where TEntity : class
    {
        #region Constructor

        private readonly IRepositoryBase<TEntity> _repository;
        private readonly ValidationResult _validationResult;

        public Service(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
            _validationResult = new ValidationResult();
        }

        #endregion

        #region Properties

        protected IRepositoryBase<TEntity> Repository
        {
            get { return _repository; }
        }

        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        #endregion

        #region Read Methods

        public virtual TEntity Get(int id, bool @readonly = false)
        {
            ////return @readonly
            ////    ? _readOnlyRepository.Get(id)
            ////    : 
            //    return _repository.Select(id);
            throw new NotImplementedException();
        }

        public virtual TEntity GetAllReferences(int id, bool @readonly = false)
        {
            ////return @readonly
            ////    ? _readOnlyRepository.GetAllReferences(id)
            ////    :
            //    return _repository.(id);
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> All(bool @readonly = false)
        {
            //return @readonly
            //    ? _readOnlyRepository.All()
            //    :
                return _repository.Select();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            //return @readonly
            //    ? _readOnlyRepository.Find(predicate)
            //    :
                //return _repository.Find(predicate);
            throw new NotImplementedException();
        }

        #endregion

        #region CRUD Methods

        public virtual ValidationResult Add(TEntity entity)
        {
            if (!ValidationResult.EstaValidado)
                return ValidationResult;

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.EhValido)
                return selfValidationEntity.ValidationResult;


            _repository.Insert(entity);
            return _validationResult;
        }

        public virtual ValidationResult Update(TEntity entity)
        {
            if (!ValidationResult.EstaValidado)
                return ValidationResult;

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.EhValido)
                return selfValidationEntity.ValidationResult;

            _repository.Update(entity);
            return _validationResult;
        }

        public virtual ValidationResult Delete(TEntity entity)
        {
            if (!ValidationResult.EstaValidado)
                return ValidationResult;

            _repository.Delete(entity);
            return _validationResult;
        }

        public List<ValidationResult> Delete(List<TEntity> entity)
        {
            var validation = new List<ValidationResult>();
            foreach (var item in entity)
            {
                validation.Add(Delete(item));
            }
            return validation;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            //return @readonly
            //    ? _readOnlyRepository.Find(predicate).FirstOrDefault()
            //    :
            //return _repository.Select(predicate).FirstOrDefault();
            throw new NotImplementedException();
        }

        public List<ValidationResult> Add(List<TEntity> entity)
        {
            var validation = new List<ValidationResult>();
            foreach (var item in entity)
            {
                validation.Add(Add(item));
            }
            return validation;
        }

        //public RetornoPesquisa<TEntity> BuscarPesquisa(Expression<Func<TEntity, bool>> filtros, int tamanhoPagina,
        //    int pagina, Func<TEntity, IComparable> ordenacao)
        //{
        //    try
        //    {
        //        return _repository.Pesquisar(filtros, tamanhoPagina, pagina, ordenacao);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ServiceWebForLinkException("Erro ao buscar um destinatário por Id", ex);
        //    }
        //}

        #endregion
    }
}
