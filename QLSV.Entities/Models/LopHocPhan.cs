using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("lop_mon_hoc")]
    public class LopHocPhan : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("ma_lop")]
        public string MaLopHp { get; set; }
        [Column("so_tin_chi")]
        public int SoTinChi { get; set; }
        [Column("mon_hoc_id")]
        public int MonHocId { get; set; }
        [Column("ki_hoc_nam_hoc_id")]
        public int KyHocNamHocId { get; set; }
        [Column("ngay_hoc_1")]
        public int NgayHoc1 { get; set; }
        [Column("ngay_hoc_2")]
        public int NgayHoc2 { get; set; }
        [Column("tiet_hoc_1")]
        public string TietHoc1 { get; set; }
        [Column("tiet_hoc_2")]
        public string TietHoc2 { get; set; }
        [Column("ngay_bat_dau")]
        public DateTime NgayBatDau { get; set; }
        [Column("giao_vien_id")]
        public int GiaoVienId { get; set; }
        [Column("so_luong_toi_da")]
        public int SoLuongChoPhep { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
