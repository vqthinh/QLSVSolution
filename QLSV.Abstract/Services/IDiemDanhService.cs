using System.Collections.Generic;
using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface IDiemDanhService:IBaseService<DiemDanh>
    {
        IList<KetQuaDiemDanh> GetKetQuaDiemDanhs(int sinhVienId, int? hocKyId);
    }
}