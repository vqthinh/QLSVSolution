using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class GiayToService : BaseService<GiayTo>, IGiayToService
    {
        private readonly ISinhVienGiayToRepository _sinhVienGiayToRepository;

        public GiayToService()
        {
            _sinhVienGiayToRepository = UnitOfWork.Repository<SinhVienGiayTo>() as ISinhVienGiayToRepository;
        }
        public void YeuCauGiayTo(SinhVienGiayTo sinhVienGiayTo)
        {
            _sinhVienGiayToRepository.Add(sinhVienGiayTo);
            UnitOfWork.SaveChanges();
        }
    }
}
