using System.Collections;
using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface ISinhVienService : IBaseService<SinhVien>
    {
        IList<SinhVien> GetListSinhViens(string keyword, int page, int size);

        IList<Khoa> GetKhoa();

        IList<KhoaHoc> GetKhoaHocs();
    }
}
