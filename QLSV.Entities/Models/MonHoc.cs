using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("mon_hoc")]
    public class MonHoc : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("ma_mon_hoc")]
        public string MaMonHoc { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
