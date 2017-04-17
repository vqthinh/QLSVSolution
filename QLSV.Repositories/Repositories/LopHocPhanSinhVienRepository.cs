using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LopHocPhanSinhVienRepository : BaseRepository<LopHocPhanSinhVien>,ILopHocPhanSinhVienRepository
    {
        private readonly QlsvDbContext _context;
        public LopHocPhanSinhVienRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public List<LopHocPhanSinhVien> GetByLopHpId(int id)
        {
            return _context.LopHocPhanSinhViens.Where(x => x.LopHocPhanId == id).ToList();
        }
    }
}
