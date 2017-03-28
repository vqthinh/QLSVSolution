using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("ki_hoc_nam_hoc")]
    public class KyHocNamHoc : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ngay_bat_dau")]
        public DateTime NgayBatDau { get; set; }
        [Column("ngay_ket_thuc")]
        public DateTime NgayKetThuc { get; set; }
        [Column("ki_hoc_id")]
        public int HocKyId { get; set; }
        [Column("nam_hoc_id")]
        public int NamHocId { get; set; }

        [ForeignKey("HocKyId")]
        public virtual HocKy HocKy { get; set; }
        [ForeignKey("NamHocId")]
        public virtual NamHoc NamHoc { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
        [NotMapped]
        public string Display => HocKy.Ten + " " + NamHoc.Ten;
    }
}
