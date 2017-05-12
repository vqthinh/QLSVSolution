using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class DotNhapDiemRepository : BaseRepository<DotNhapDiem>, IDotNhapDiemRepository
    {
        public DotNhapDiemRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
