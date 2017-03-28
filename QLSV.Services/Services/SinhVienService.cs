using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Common.Enum;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class SinhVienService : BaseService<SinhVien>,ISinhVienService
    {
        private readonly ISinhVienRepository _sinhVienRepository;
        private readonly IDiemRenLuyenRepository _diemRenLuyenRepository;
        private readonly ITaiKhoanRepository _taiKhoanRepository;

        public SinhVienService()
        {
            _sinhVienRepository = UnitOfWork.Repository<SinhVien>() as ISinhVienRepository;
            _diemRenLuyenRepository = UnitOfWork.Repository<DiemRenLuyen>() as IDiemRenLuyenRepository;
            _taiKhoanRepository = UnitOfWork.Repository<TaiKhoan>() as ITaiKhoanRepository;
        }

        public IList<SinhVien> GetListSinhViens(string keyword, int page, int size)
        {
            if (string.IsNullOrEmpty(keyword))
                return _sinhVienRepository.GetPage(p => p.OrderBy(x => x.MaSv), null, page, size);
            return _sinhVienRepository.GetPage(p => p.OrderBy(x => x.MaSv), p => p.Ten.ToLower().Contains(keyword.ToLower()) || p.HoDem.ToLower().Contains(keyword.ToLower()), page, size);
        }

        public IList<Khoa> GetKhoa()
        {
            return _sinhVienRepository.GetKhoas();
        }

        public new bool Add(SinhVien sinhVien)
        {
            var countSv = _sinhVienRepository.Where(x => x.MaSv == sinhVien.MaSv).Any();
            if (!countSv)
            {
                _sinhVienRepository.Add(sinhVien);
                UnitOfWork.SaveChanges();
                _diemRenLuyenRepository.Add(new DiemRenLuyen
                        {
                            SinhVienId = sinhVien.Id
                        }
                    );
                _taiKhoanRepository.Add(new TaiKhoan
                {
                    TenDangNhap = "sv" + sinhVien.MaSv,
                    MatKhau = sinhVien.MaSv,
                    IdNguoiDung = sinhVien.Id,
                    LoaiNguoiDung = (int)UserType.SinhVien
                });
                UnitOfWork.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<KhoaHoc> GetKhoaHocs()
        {
            return _sinhVienRepository.GetKhoaHocs();
        }
    }
}
