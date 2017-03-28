namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.giang_duong")]
    public partial class giang_duong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public giang_duong()
        {
            mon_hoc_giang_duong = new HashSet<mon_hoc_giang_duong>();
            tkb_lich_hoc_theo_ngay = new HashSet<tkb_lich_hoc_theo_ngay>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string ma_giang_duong { get; set; }

        public int tang { get; set; }

        [Required]
        [StringLength(50)]
        public string ten { get; set; }

        public int day_nha_id { get; set; }

        public virtual day_nha day_nha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mon_hoc_giang_duong> mon_hoc_giang_duong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tkb_lich_hoc_theo_ngay> tkb_lich_hoc_theo_ngay { get; set; }
    }
}
