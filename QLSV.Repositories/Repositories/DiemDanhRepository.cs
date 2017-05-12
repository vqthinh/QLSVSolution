using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class DiemDanhRepository : BaseRepository<DiemDanh>, IDiemDanhRepository
    {
        private QlsvDbContext _context;
        public DiemDanhRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<DiemDanh> GetListDiemDanh(int lopHocPhanId, int sinhVienId, bool? coMat)
        {
            if (coMat == null)
            {
                return
                    _context.DiemDanhs.Where(x => x.LopHocPhanId == lopHocPhanId && x.SinhVienId == sinhVienId).ToList();
            }
            else
            {
                return
                    _context.DiemDanhs.Where(x => x.LopHocPhanId == lopHocPhanId && x.SinhVienId == sinhVienId && x.CoMat == coMat).ToList();
            }
        }
    }
}
