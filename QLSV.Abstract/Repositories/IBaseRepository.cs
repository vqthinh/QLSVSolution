using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QLSV.Entities;

namespace QLSV.Abstract.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class , IEntityBase
    {
        bool Add(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(int id);

        IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);

        IList<TEntity> GetPage(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy,
            Expression<Func<TEntity, bool>> filter = null, int page = 1, int size = 10, bool deleted = false);

        TEntity GetById(int id);

        int GetTotal();

        int Total();

        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
    }
}
