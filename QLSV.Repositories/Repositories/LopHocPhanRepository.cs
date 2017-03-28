using System;
using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LopHocPhanRepository : BaseRepository<LopHocPhan>,ILopHocPhanRepository
    {
        private readonly QlsvDbContext _context;
        public LopHocPhanRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<MonHoc> GetMonHocs()
        {
            return _context.Set<MonHoc>().Where(x=>x.Deleted==false).ToList();
        }

        public bool AddMonHoc(MonHoc monHoc)
        {
            try
            {
                _context.Set<MonHoc>().Add(monHoc);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IList<KyHocNamHoc> GetHocKies()
        {
            return _context.Set<KyHocNamHoc>().Where(x => x.Deleted == false).ToList();
        }
    }
}
