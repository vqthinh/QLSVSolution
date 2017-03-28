namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.vai_tro_chuc_nang")]
    public partial class vai_tro_chuc_nang
    {
        public int id { get; set; }

        public int chuc_nang_id { get; set; }

        public int vai_tro_id { get; set; }

        public virtual chuc_nang chuc_nang { get; set; }

        public virtual vai_tro vai_tro { get; set; }
    }
}
