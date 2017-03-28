using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class GiaoVienRepository : BaseRepository<GiaoVien>,IGiaoVienRepository
    {
        public GiaoVienRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
