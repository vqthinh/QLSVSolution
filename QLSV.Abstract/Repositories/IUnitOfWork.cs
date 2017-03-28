using System;
using QLSV.Entities;

namespace QLSV.Abstract.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();

        void Dispose(bool disposing);

        IBaseRepository<TEntity> Repository<TEntity>() where TEntity : class,IEntityBase;
    }
}
