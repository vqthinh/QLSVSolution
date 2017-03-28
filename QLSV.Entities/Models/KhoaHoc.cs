using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("khoa_hoc")]
    public class KhoaHoc : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("nam_bat_dau")]
        public int NamBatDau { get; set; }
        [Column("nam_ket_thuc")]
        public int NamKetThuc { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
