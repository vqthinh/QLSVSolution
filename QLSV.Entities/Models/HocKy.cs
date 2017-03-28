using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("ki_hoc")]
    public class HocKy : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
