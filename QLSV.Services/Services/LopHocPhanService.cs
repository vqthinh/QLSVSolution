using System.Collections.Generic;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class LopHocPhanService : BaseService<LopHocPhan>,ILopHocPhanService
    {
        private readonly ILopHocPhanRepository _lopHocPhanRepository;

        public LopHocPhanService()
        {
               _lopHocPhanRepository = UnitOfWork.Repository<LopHocPhan>() as ILopHocPhanRepository;
        }

        public IList<MonHoc> GetMonHocs()
        {
            return _lopHocPhanRepository.GetMonHocs();
        }

        public bool AddMonHoc(MonHoc monHoc)
        {
            if (_lopHocPhanRepository.AddMonHoc(monHoc))
            {
                UnitOfWork.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<KyHocNamHoc> GetHocKies()
        {
            return _lopHocPhanRepository.GetHocKies();
        }
    }
}
