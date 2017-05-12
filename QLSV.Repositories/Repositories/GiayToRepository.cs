using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class GiayToRepository : BaseRepository<GiayTo>, IGiayToRepository
    {
        public GiayToRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
