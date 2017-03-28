using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using QLSV.Abstract.Repositories;
using QLSV.Entities;

namespace QLSV.Repositories.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class , IEntityBase
    {
        private readonly QlsvDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(QlsvDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public bool Add(TEntity entity)
        {
            try
            {
                entity.Deleted = false;
                _dbSet.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty)).ToList();
        }

        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().AsNoTracking().Where(predicate);
        }

        private int _total;

        public int Total()
        {
            return _total;
        }

        public IList<TEntity> GetPage(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, Expression<Func<TEntity, bool>> filter = null, int page = 1, int size = 10, bool deleted = false)
        {

            var order = filter != null
                ? orderBy(_context.Set<TEntity>().Where(x => x.Deleted == deleted).Where(filter))
                : orderBy(_context.Set<TEntity>().Where(x => x.Deleted == deleted));
            _total = order.Count();
            if (page == 0)
            {
                return order.Skip(0).Take(size).ToList();
            }
            if (page == 1)
            {
                return order.Skip(size).Take(size).ToList();
            }
            return order.Skip((page) * size).Take(size).ToList();
        }

        public bool Update(TEntity entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                _context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetTotal()
        {
            return _dbSet.Count();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = GetById(id);
                entity.Deleted = true;
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
