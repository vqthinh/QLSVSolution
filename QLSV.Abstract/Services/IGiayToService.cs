using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface IGiayToService : IBaseService<GiayTo>
    {
        void YeuCauGiayTo(SinhVienGiayTo sinhVienGiayTo);
    }
}