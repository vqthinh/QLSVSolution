using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface ISinhVienRepository : IBaseRepository<SinhVien>
    {
        List<Khoa> GetKhoas();

        IList<KhoaHoc> GetKhoaHocs();
    }
}
