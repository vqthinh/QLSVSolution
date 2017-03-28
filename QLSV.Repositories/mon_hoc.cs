namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.mon_hoc")]
    public partial class mon_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mon_hoc()
        {
            lop_mon_hoc = new HashSet<lop_mon_hoc>();
            mon_hoc_giang_duong = new HashSet<mon_hoc_giang_duong>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_mon_hoc { get; set; }

        [Required]
        [StringLength(30)]
        public string ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lop_mon_hoc> lop_mon_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mon_hoc_giang_duong> mon_hoc_giang_duong { get; set; }
    }
}
