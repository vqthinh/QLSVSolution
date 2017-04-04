using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface ILopHocPhanService : IBaseService<LopHocPhan>
    {
        IList<MonHoc> GetMonHocs();

        bool AddMonHoc(MonHoc monHoc);

        bool UpdateMonHoc(MonHoc monHoc);

        IList<KyHocNamHoc> GetHocKies();

        IList<LopHocPhanSinhVien> GetDanhSachSinhVien(int id);

        IList<SinhVien> GetSinhVienToAdd(int id);

        bool AddSinhVienToLopHp(int id, int[] keys);

        MonHoc GetMonHocById(int id);

        bool DeleteMonHoc(int id);
    }
}