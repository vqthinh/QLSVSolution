using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("lop_hoc")]
    public class Lop : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("khoa_id")]
        public int KhoaId { get; set; }
        [Column("khoa_hoc_id")]
        public int KhoaHocId { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
