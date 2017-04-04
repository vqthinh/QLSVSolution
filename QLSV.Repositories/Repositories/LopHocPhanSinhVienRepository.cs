using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LopHocPhanSinhVienRepository : BaseRepository<LopHocPhanSinhVien>
    {
        public LopHocPhanSinhVienRepository(QlsvDbContext context) : base(context)
        {
        }
    }
}
