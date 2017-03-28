using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("nam_hoc")]
    public class NamHoc : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Ten { get; set; }
        [Column("ngay_bat_dau")]
        public DateTime NgayBatDau { get; set; }
        [Column("ngay_ket_thuc")]
        public DateTime NgayKetThuc { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
