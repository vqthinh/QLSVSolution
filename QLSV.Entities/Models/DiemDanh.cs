using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("diem_danh")]
    public class DiemDanh : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("sinh_vien_id")]
        public int SinhVienId { get; set; }
        [Column("lop_mon_hoc_id")]
        public int LopHocPhanId { get; set; }
        [Column("giao_vien_id")]
        public int GiaoVienId { get; set; }
        [Column("ngay_diem_danh")]
        public DateTime NgayDiemDanh { get; set; }
        [Column("co_mat")]
        public bool CoMat { get; set; }
        [Column("phep")]
        public bool Phep { get; set; }

        [ForeignKey("SinhVienId")]
        public virtual SinhVien SinhVien { get; set; }
        [ForeignKey("GiaoVienId")]
        public virtual GiaoVien GiaoVien { get; set; }
        [ForeignKey("LopHocPhanId")]
        public virtual LopHocPhan LopHocPhan { get; set; }

        public bool? Deleted { get; set; }
    }
}
