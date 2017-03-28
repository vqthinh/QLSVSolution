using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Common.Enum;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class GiaoVienService : BaseService<GiaoVien>,IGiaoVienService
    {
        private readonly ITaiKhoanRepository _taiKhoanRepository;
        public GiaoVienService()
        {
            _taiKhoanRepository = UnitOfWork.Repository<TaiKhoan>() as ITaiKhoanRepository;
        }
        public new bool Add(GiaoVien giaoVien)
        {
            var countSv = Repository.Where(x => x.MaGv == giaoVien.MaGv).Any();
            if (!countSv)
            {
                Repository.Add(giaoVien);
                UnitOfWork.SaveChanges();
                _taiKhoanRepository.Add(new TaiKhoan
                {
                    TenDangNhap = "gv" + giaoVien.MaGv,
                    MatKhau = giaoVien.MaGv,
                    IdNguoiDung = giaoVien.Id,
                    LoaiNguoiDung = (int)UserType.GiaoVien
                });
                UnitOfWork.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
