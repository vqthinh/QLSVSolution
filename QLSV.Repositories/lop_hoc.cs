namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.lop_hoc")]
    public partial class lop_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lop_hoc()
        {
            sinh_vien = new HashSet<sinh_vien>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string ma { get; set; }

        [StringLength(255)]
        public string ten { get; set; }

        public int? khoa_hoc_id { get; set; }

        public int? khoa_id { get; set; }

        public bool? deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sinh_vien> sinh_vien { get; set; }
    }
}
