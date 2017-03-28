using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class SinhVienRepository : BaseRepository<SinhVien>, ISinhVienRepository
    {
        private readonly QlsvDbContext _context;
        public SinhVienRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Khoa> GetKhoas()
        {
            return _context.Set<Khoa>().ToList();
        }

        public IList<KhoaHoc> GetKhoaHocs()
        {
            return _context.Set<KhoaHoc>().ToList();
        }
    }
}
