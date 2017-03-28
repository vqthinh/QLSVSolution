using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities;
using QLSV.Repositories.Repositories;

namespace QLSV.Services.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class , IEntityBase
    {
        protected IUnitOfWork UnitOfWork;
        protected IBaseRepository<TEntity> Repository;

        public BaseService()
        {
            UnitOfWork = new UnitOfWork();
            Repository = UnitOfWork.Repository<TEntity>();
        }

        public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            return Repository.GetAll();
        }

        public IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Where(predicate).ToList();
        }

        public bool Add(TEntity entity)
        {
            try
            {
                Repository.Add(entity);
                UnitOfWork.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int Total()
        {
            return Repository.Total();
        }

        public bool Update(TEntity entity)
        {
            try
            {
                Repository.Update(entity);
                UnitOfWork.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Repository.Delete(id);
                UnitOfWork.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TEntity GetById(int id)
        {
            return Repository.GetById(id);
        }
    }
}
