using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface IDiemDanhRepository: IBaseRepository<DiemDanh>
    {
        IList<DiemDanh> GetListDiemDanh(int lopHocPhanId, int sinhVienId, bool? coMat);
    }
}
