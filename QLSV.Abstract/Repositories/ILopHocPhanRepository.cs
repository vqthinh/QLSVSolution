using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface ILopHocPhanRepository : IBaseRepository<LopHocPhan>
    {
        IList<MonHoc> GetMonHocs();

        bool AddMonHoc(MonHoc monHoc);

        IList<KyHocNamHoc> GetHocKies();

        IList<LopHocPhanSinhVien> GetDanhSachSinhVien(int id);

        IList<SinhVien> GetSinhVienToAdd(int id);

        bool AddSvToLopHp(int id, int sinhVienId);
    }
}