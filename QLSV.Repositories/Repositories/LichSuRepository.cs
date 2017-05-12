using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LichSuRepository : BaseRepository<LichSu>, ILichSuRepository
    {
        public LichSuRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
