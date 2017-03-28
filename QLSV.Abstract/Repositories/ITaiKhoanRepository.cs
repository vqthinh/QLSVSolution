using QLSV.Entities.Models;

namespace QLSV.Abstract.Repositories
{
    public interface ITaiKhoanRepository : IBaseRepository<TaiKhoan>
    {
        TaiKhoan DangNhap(TaiKhoan taiKhoan);
    }
}
