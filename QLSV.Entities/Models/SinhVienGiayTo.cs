using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("sinh_vien_giay_to")]
    public class SinhVienGiayTo : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("giay_to_id")]
        public int GiayToId { get; set; }
        [Column("sinh_vien_id")]
        public int SinhVienId { get; set; }
        [Column("ly_do")]
        public string LyDo { get; set; }
        [Column("ngay_yeu_cau")]
        public DateTime NgayYeuCau { get; set; }
        [Column("ngay_xac_nhan")]
        public DateTime NgayXacNhan { get; set; }
        [Column("so_luong")]
        public int SoLuong { get; set; }
        [Column("tinh_trang")]
        public string TinhTrang { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }

        [ForeignKey("SinhVienId")]
        public virtual SinhVien SinhVien { get; set; }
        [ForeignKey("GiayToId")]
        public virtual GiayTo GiayTo { get; set; }
    }
}
