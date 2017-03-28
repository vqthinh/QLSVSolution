using QLSV.Entities.Models;

namespace QLSV.Repositories
{
    using System.Data.Entity;

    public class QlsvDbContext : DbContext
    {
        public QlsvDbContext()
            : base("name=QLSVDbContext")
        {
        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<DiemRenLuyen> DiemRenLuyens { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<GiaoVien> GiaoViens { get; set; }
        public DbSet<LopHocPhan> LopHocPhans { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<HocKy> HocKies { get; set; }
        public DbSet<NamHoc> NamHocs { get; set; }
        public DbSet<KyHocNamHoc> KyHocNamHocs { get; set; }
        public DbSet<LopHocPhanSinhVien> LopHocPhanSinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
