using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LopRepository : BaseRepository<Lop>,ILopRepository
    {
        private readonly QlsvDbContext _context;
        public LopRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Lop> GetByKhoaId(int id)
        {
            return _context.Set<Lop>().Where(x => x.KhoaId == id).ToList();
        }
    }
}
