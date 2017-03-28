using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("giao_vien")]
    public class GiaoVien : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ho_dem")]
        public string HoDem { get; set; }
        [Column("ma_giao_vien")]
        public string MaGv { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
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
        [Column("gioi_tinh")]
        public bool GioiTinh { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }

        [NotMapped]
        public string TenDayDu => HoDem + " " + Ten;
    }
}
