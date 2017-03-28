namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.ki_hoc")]
    public partial class ki_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ki_hoc()
        {
            ki_hoc_nam_hoc = new HashSet<ki_hoc_nam_hoc>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ki_hoc_nam_hoc> ki_hoc_nam_hoc { get; set; }
    }
}
