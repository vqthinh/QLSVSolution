using QLSV.Entities.Models;

namespace QLSV.Abstract.Services
{
    public interface ILopHocPhanSinhVienService : IBaseService<LopHocPhanSinhVien>
    {
        void XetDiemChuyenCan(int id);
        void XepLoai(int id);
    }
}