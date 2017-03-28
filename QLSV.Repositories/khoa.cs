namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.khoa")]
    public partial class khoa
    {
        public int id { get; set; }

        [StringLength(1073741823)]
        public string ten { get; set; }

        public bool? deleted { get; set; }
    }
}
