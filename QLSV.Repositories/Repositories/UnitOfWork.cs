using System;
using System.Collections.Generic;
using QLSV.Abstract.Repositories;
using QLSV.Entities;

namespace QLSV.Repositories.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private readonly Dictionary<string, object> _repositories;
        private readonly QlsvDbContext _dataContext;

        public UnitOfWork()
        {
            _dataContext = new QlsvDbContext();
            _repositories = new Dictionary<string, object>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dataContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }

        public IBaseRepository<TEntity> Repository<TEntity>() where TEntity : class,IEntityBase
        {
            var entityType = typeof(TEntity).Name.ToUpper();

            if (_repositories.ContainsKey(entityType))
                return (IBaseRepository<TEntity>)_repositories[entityType];

            object entityRepository = null;

            switch (entityType)
            {
                case "SINHVIEN":
                    entityRepository = new SinhVienRepository(_dataContext);
                    break;
                case "KHOA":
                    entityRepository = new KhoaRepository(_dataContext);
                    break;
                case "LOP":
                    entityRepository = new LopRepository(_dataContext);
                    break;
                case "TAIKHOAN":
                    entityRepository = new TaiKhoanRepository(_dataContext);
                    break;
                case "DIEMRENLUYEN":
                    entityRepository = new DiemRenLuyenRepository(_dataContext);
                    break;
                case "GIAOVIEN":
                    entityRepository = new GiaoVienRepository(_dataContext);
                    break;
                case "LOPHOCPHAN":
                    entityRepository = new LopHocPhanRepository(_dataContext);
                    break;
            }

            _repositories.Add(entityType, entityRepository);

            return (IBaseRepository<TEntity>)_repositories[entityType];
        }
    }
}
