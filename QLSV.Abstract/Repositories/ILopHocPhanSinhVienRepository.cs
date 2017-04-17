using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface ILopHocPhanSinhVienRepository: IBaseRepository<LopHocPhanSinhVien>
    {
        List<LopHocPhanSinhVien> GetByLopHpId(int id);
    }
}
