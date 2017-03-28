using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface ITaiKhoanService : IBaseService<TaiKhoan>
    {
        TaiKhoan DangNhap(TaiKhoan taiKhoan);

        LoginModel ThongTinDangNhap(TaiKhoan taiKhoan);
    }
}
