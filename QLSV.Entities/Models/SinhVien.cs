using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("sinh_vien")]
    public class SinhVien : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ho_dem")]
        public string HoDem { get; set; }
        [Column("ma_sinh_vien")]
        public string MaSv { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("lop_hoc_id")]
        public int? LopHocId { get; set; }
        [Column("khoa_hoc_id")]
        public int? KhoaHocId { get; set; }
        [Column("ngay_sinh")]
        public DateTime? NgaySinh { get; set; }
        [Column("ho_khau")]
        public string HoKhau { get; set; }
        [Column("quoc_tich")]
        public string QuocTich { get; set; }
        [Column("dia_chi")]
        public string DiaChi { get; set; }
        [Column("noi_sinh")]
        public string NoiSinh { get; set; }
        [Column("dan_toc")]
        public string DanToc { get; set; }
        [Column("dien_thoai")]
        public string DienThoai { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("cmnd")]
        public string Cmnd { get; set; }
        [Column("ngay_cap")]
        public DateTime? NgayCap { get; set; }
        [Column("noi_cap")]
        public string NoiCap { get; set; }
        [Column("ho_ten_cha")]
        public string HoTenCha { get; set; }
        [Column("dien_thoai_cha")]
        public string DienThoaiCha { get; set; }
        [Column("ho_ten_me")]
        public string HoTenMe { get; set; }
        [Column("dien_thoai_me")]
        public string DienThoaiMe { get; set; }
        [Column("gioi_tinh")]
        public bool GioiTinh { get; set; }
        [Column("khoa_id")]
        public int? KhoaId { get; set; }
        [ForeignKey("LopHocId")]
        public virtual Lop Lop { get; set; }

        [ForeignKey("KhoaId")]
        public virtual Khoa Khoa { get; set; }

        [ForeignKey("KhoaHocId")]
        public virtual KhoaHoc KhoaHoc { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }

        [NotMapped]
        public string TenDayDu => HoDem + " " + Ten;
    }
}
