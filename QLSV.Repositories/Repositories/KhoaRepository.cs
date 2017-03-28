using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class KhoaRepository : BaseRepository<Khoa>,IKhoaRepository
    {
        public KhoaRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
