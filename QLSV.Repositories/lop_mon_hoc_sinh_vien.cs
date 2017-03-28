namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.lop_mon_hoc_sinh_vien")]
    public partial class lop_mon_hoc_sinh_vien
    {
        public int id { get; set; }

        public int lop_mon_hoc_id { get; set; }

        public int sinh_vien_id { get; set; }

        public bool? da_nop { get; set; }

        public decimal? diem_cc { get; set; }

        public decimal? diem_gk { get; set; }

        public decimal? diem_ck1 { get; set; }

        public decimal? diem_ck2 { get; set; }

        public bool? deleted { get; set; }

        public virtual lop_mon_hoc lop_mon_hoc { get; set; }

        public virtual sinh_vien sinh_vien { get; set; }
    }
}
