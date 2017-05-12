using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("lich_su")]
    public class LichSu : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("user_name")]
        public string UserName { get; set; }
        [Column("thoi_gian")]
        public DateTime ThoiGian { get; set; }
        [Column("mo_ta")]
        public string MoTa { get; set; }
        [Column("loai_lich_su")]
        public int LoaiLichSu { get; set; }
        [NotMapped]
        public bool? Deleted { get; set; }
    }
}
