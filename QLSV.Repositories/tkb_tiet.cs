namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.tkb_tiet")]
    public partial class tkb_tiet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tkb_tiet()
        {
            tkb_lich_hoc_theo_ngay = new HashSet<tkb_lich_hoc_theo_ngay>();
            tkb_lich_hoc_theo_ngay1 = new HashSet<tkb_lich_hoc_theo_ngay>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string ten { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tkb_lich_hoc_theo_ngay> tkb_lich_hoc_theo_ngay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tkb_lich_hoc_theo_ngay> tkb_lich_hoc_theo_ngay1 { get; set; }
    }
}
