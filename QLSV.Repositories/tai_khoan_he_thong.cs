namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.tai_khoan_he_thong")]
    public partial class tai_khoan_he_thong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tai_khoan_he_thong()
        {
            tai_khoan_he_thong_vai_tro = new HashSet<tai_khoan_he_thong_vai_tro>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(70)]
        public string ho_va_ten { get; set; }

        [Required]
        [StringLength(50)]
        public string mat_khau { get; set; }

        [Required]
        [StringLength(20)]
        public string ten_dang_nhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tai_khoan_he_thong_vai_tro> tai_khoan_he_thong_vai_tro { get; set; }
    }
}
