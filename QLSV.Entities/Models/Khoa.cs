using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("khoa")]
    public class Khoa : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten")]
        public string Ten{ get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
