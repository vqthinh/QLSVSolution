using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Common.Enum;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class TaiKhoanService : BaseService<TaiKhoan>, ITaiKhoanService
    {
        private readonly ITaiKhoanRepository _taiKhoanRepository;
        private readonly ISinhVienRepository _sinhVienRepository;

        public TaiKhoanService()
        {
            _taiKhoanRepository = UnitOfWork.Repository<TaiKhoan>() as ITaiKhoanRepository;
            _sinhVienRepository = UnitOfWork.Repository<SinhVien>() as ISinhVienRepository;
        }
        public TaiKhoan DangNhap(TaiKhoan taiKhoan)
        {
            return _taiKhoanRepository.DangNhap(taiKhoan);
        }

        public LoginModel ThongTinDangNhap(TaiKhoan taiKhoan)
        {
            switch (taiKhoan.LoaiNguoiDung)
            {
                case (int)UserType.GiaoVu:
//                    var giaoVu = _sinhVienRepository.GetById(taiKhoan.IdNguoiDung);
                    return new LoginModel
                    {
                        HoTen = "Giáo Vụ",
                        IdNguoiDung = 1,
                        LoaiNguoiDung = (int)UserType.GiaoVu,
                        TenDangNhap = taiKhoan.TenDangNhap
                    };
                case (int)UserType.GiaoVien:
                    var giaoVien = _sinhVienRepository.GetById(taiKhoan.IdNguoiDung.GetValueOrDefault());
                    return new LoginModel
                    {
                        HoTen = giaoVien.HoDem + " " + giaoVien.Ten,
                        IdNguoiDung = giaoVien.Id,
                        LoaiNguoiDung = (int)UserType.GiaoVien,
                        TenDangNhap = taiKhoan.TenDangNhap
                    };
                case (int)UserType.SinhVien:
                    var sinhVien = _sinhVienRepository.GetById(taiKhoan.IdNguoiDung.GetValueOrDefault());
                    return new LoginModel
                    {
                        HoTen = sinhVien.HoDem + " " + sinhVien.Ten,
                        IdNguoiDung = sinhVien.Id,
                        LoaiNguoiDung = (int)UserType.SinhVien,
                        TenDangNhap = taiKhoan.TenDangNhap
                    };
            }
            return new LoginModel();
        }
    }
}
