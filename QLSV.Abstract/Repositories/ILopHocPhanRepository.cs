using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface ILopHocPhanRepository : IBaseRepository<LopHocPhan>
    {
        IList<MonHoc> GetMonHocs();

        bool AddMonHoc(MonHoc monHoc);

        IList<KyHocNamHoc> GetHocKies();
    }
}