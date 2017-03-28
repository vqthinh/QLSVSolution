namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.ki_hoc_nam_hoc")]
    public partial class ki_hoc_nam_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ki_hoc_nam_hoc()
        {
            lop_mon_hoc = new HashSet<lop_mon_hoc>();
        }

        public int id { get; set; }

        public DateTime ngay_bat_dau { get; set; }

        public DateTime ngay_ket_thuc { get; set; }

        public int ki_hoc_id { get; set; }

        public int nam_hoc_id { get; set; }

        public virtual ki_hoc ki_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lop_mon_hoc> lop_mon_hoc { get; set; }

        public virtual nam_hoc nam_hoc { get; set; }
    }
}
