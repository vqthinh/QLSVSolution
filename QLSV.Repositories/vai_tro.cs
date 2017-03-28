namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.vai_tro")]
    public partial class vai_tro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vai_tro()
        {
            tai_khoan_he_thong_vai_tro = new HashSet<tai_khoan_he_thong_vai_tro>();
            vai_tro_chuc_nang = new HashSet<vai_tro_chuc_nang>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string ten_vai_tro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tai_khoan_he_thong_vai_tro> tai_khoan_he_thong_vai_tro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vai_tro_chuc_nang> vai_tro_chuc_nang { get; set; }
    }
}
