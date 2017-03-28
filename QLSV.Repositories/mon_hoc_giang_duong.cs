namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.mon_hoc_giang_duong")]
    public partial class mon_hoc_giang_duong
    {
        public int id { get; set; }

        public int giang_duong_id { get; set; }

        public int mon_hoc_id { get; set; }

        public virtual giang_duong giang_duong { get; set; }

        public virtual mon_hoc mon_hoc { get; set; }
    }
}
