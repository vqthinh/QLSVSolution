using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("dot_nhap_diem")]
    public class DotNhapDiem : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ki_hoc_nam_hoc_id")]
        public int KiHocNamHocId { get; set; }
        [Column("gio_bat_dau")]
        public DateTime GioBatDau { get; set; }
        [Column("gio_ket_thuc")]
        public DateTime GioKetThuc { get; set; }
        [Column("loai_diem")]
        public int LoaiDiem { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
        [ForeignKey("KiHocNamHocId")]
        public virtual KyHocNamHoc KyHocNamHoc { get; set; }
    }
}
