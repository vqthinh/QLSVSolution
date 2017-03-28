using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("diem_ren_luyen")]
    public class DiemRenLuyen : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("sinh_vien_id")]
        public int SinhVienId { get; set; }
        [Column("hk1")]
        public int Hk1 { get; set; }
        [Column("hk2")]
        public int Hk2 { get; set; }
        [Column("hk3")]
        public int Hk3 { get; set; }
        [Column("hk4")]
        public int Hk4 { get; set; }
        [Column("hk5")]
        public int Hk5 { get; set; }
        [Column("hk6")]
        public int Hk6 { get; set; }
        [Column("hk7")]
        public int Hk7 { get; set; }
        [Column("hk8")]
        public int Hk8 { get; set; }
        [Column("hk9")]
        public int Hk9 { get; set; }
        [Column("hk10")]
        public int Hk10 { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }

        [ForeignKey("SinhVienId")]
        public virtual SinhVien SinhVien { get; set; }
    }
}
