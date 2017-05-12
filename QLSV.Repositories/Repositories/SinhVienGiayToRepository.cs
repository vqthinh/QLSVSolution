using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class SinhVienGiayToRepository : BaseRepository<SinhVienGiayTo> , ISinhVienGiayToRepository
    {
        public SinhVienGiayToRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
