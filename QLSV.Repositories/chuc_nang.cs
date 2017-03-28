namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.chuc_nang")]
    public partial class chuc_nang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chuc_nang()
        {
            vai_tro_chuc_nang = new HashSet<vai_tro_chuc_nang>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ten_chuc_nang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vai_tro_chuc_nang> vai_tro_chuc_nang { get; set; }
    }
}
