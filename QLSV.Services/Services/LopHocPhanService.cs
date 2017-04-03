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

        public IList<LopHocPhanSinhVien> GetDanhSachSinhVien(int id)
        {
            return _lopHocPhanRepository.GetDanhSachSinhVien(id);
        }

        public IList<SinhVien> GetSinhVienToAdd(int id)
        {
            return _lopHocPhanRepository.GetSinhVienToAdd(id);
        }

        public bool AddSinhVienToLopHp(int id, int[] keys)
        {
            foreach (var key in keys)
            {
                if (!_lopHocPhanRepository.AddSvToLopHp(id, key)) return false;
            }
            UnitOfWork.SaveChanges();
            return true;
        }
    }
}
