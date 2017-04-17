using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("lop_mon_hoc_sinh_vien")]
    public class LopHocPhanSinhVien : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("lop_mon_hoc_id")]
        public int LopHocPhanId { get; set; }
        [Column("sinh_vien_id")]
        public int SinhVienId { get; set; }
        [Column("da_nop")]
        public bool? DaNop { get; set; }
        [Column("diem_cc")]
        public decimal? DiemCc { get; set; }
        [Column("diem_gk")]
        public decimal? DiemGk { get; set; }
        [Column("diem_ck1")]
        public decimal? DiemCk1 { get; set; }
        [Column("diem_ck2")]
        public decimal? DiemCk2 { get; set; }
        [Column("diem_tb")]
        public decimal? DiemTb { get; set; }
        [Column("xep_loai")]
        public string XepLoai { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }

        [ForeignKey("LopHocPhanId")]
        public virtual LopHocPhan LopHocPhan { get; set; }
        [ForeignKey("SinhVienId")]
        public virtual SinhVien SinhVien { get; set; }
    }
}
