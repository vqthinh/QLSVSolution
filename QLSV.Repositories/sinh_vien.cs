namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.sinh_vien")]
    public partial class sinh_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sinh_vien()
        {
            lop_mon_hoc_sinh_vien = new HashSet<lop_mon_hoc_sinh_vien>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ho_dem { get; set; }

        [Required]
        [StringLength(25)]
        public string ma_sinh_vien { get; set; }

        [Required]
        [StringLength(20)]
        public string ten { get; set; }

        public int lop_hoc_id { get; set; }

        public int? khoa_hoc_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(1073741823)]
        public string ho_khau { get; set; }

        [StringLength(1073741823)]
        public string quoc_tich { get; set; }

        [StringLength(1073741823)]
        public string dia_chi { get; set; }

        [StringLength(1073741823)]
        public string noi_sinh { get; set; }

        [StringLength(1073741823)]
        public string dan_toc { get; set; }

        [StringLength(1073741823)]
        public string dien_thoai { get; set; }

        [StringLength(1073741823)]
        public string email { get; set; }

        [StringLength(1073741823)]
        public string cmnd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_cap { get; set; }

        [StringLength(1073741823)]
        public string noi_cap { get; set; }

        [StringLength(1073741823)]
        public string ho_ten_cha { get; set; }

        [StringLength(1073741823)]
        public string ho_ten_me { get; set; }

        [StringLength(1073741823)]
        public string dien_thoai_cha { get; set; }

        [StringLength(1073741823)]
        public string dien_thoai_me { get; set; }

        public bool? gioi_tinh { get; set; }

        public int? khoa_id { get; set; }

        public bool? deleted { get; set; }

        public virtual lop_hoc lop_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lop_mon_hoc_sinh_vien> lop_mon_hoc_sinh_vien { get; set; }
    }
}
