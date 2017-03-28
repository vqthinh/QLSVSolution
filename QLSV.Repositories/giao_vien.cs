namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.giao_vien")]
    public partial class giao_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giao_vien()
        {
            lop_mon_hoc = new HashSet<lop_mon_hoc>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ho_dem { get; set; }

        [Required]
        [StringLength(20)]
        public string ten { get; set; }

        [Required]
        [StringLength(20)]
        public string ma_giao_vien { get; set; }

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

        public bool? gioi_tinh { get; set; }

        public bool? deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lop_mon_hoc> lop_mon_hoc { get; set; }
    }
}
