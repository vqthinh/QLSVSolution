using System;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class TaiKhoanRepository : BaseRepository<TaiKhoan>,ITaiKhoanRepository
    {
        private readonly QlsvDbContext _context;
        public TaiKhoanRepository(QlsvDbContext context) : base(context)
        {
            _context = context;
        }

        public TaiKhoan DangNhap(TaiKhoan taiKhoan)
        {
            try
            {
                var taiKhoanDangNhap =
                    _context.Set<TaiKhoan>()
                        .FirstOrDefault(x => x.TenDangNhap == taiKhoan.TenDangNhap && x.MatKhau == taiKhoan.MatKhau);
                if (taiKhoanDangNhap != null)
                {
                    return taiKhoanDangNhap;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            return null;
        }
    }
}
