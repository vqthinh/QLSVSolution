using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("giay_to")]
    public class GiayTo : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten_loai")]
        public string TenLoai { get; set; }
        [Column("le_phi")]
        public double LePhi { get; set; }
        [Column("link_action")]
        public string LinkAction { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
