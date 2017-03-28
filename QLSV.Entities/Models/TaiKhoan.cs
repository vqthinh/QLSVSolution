using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tai_khoan")]
    public class TaiKhoan : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten_dang_nhap")]
        [Required(ErrorMessage = "Không được bỏ trống.")]
        public string TenDangNhap { get; set; }
        [Column("mat_khau")]
        [Required(ErrorMessage = "Không được bỏ trống.")]
        public string MatKhau { get; set; }
        [Column("loai_nguoi_dung")]
        public int? LoaiNguoiDung { get; set; }
        [Column("id_nguoi_dung")]
        public int? IdNguoiDung { get; set; }
        [Column("deleted")]
        public bool? Deleted { get; set; }
    }
}
