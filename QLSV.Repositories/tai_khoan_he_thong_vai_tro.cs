namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.tai_khoan_he_thong_vai_tro")]
    public partial class tai_khoan_he_thong_vai_tro
    {
        public int id { get; set; }

        public int? tai_khoan_he_thong_id { get; set; }

        public int? vai_tro_id { get; set; }

        public virtual tai_khoan_he_thong tai_khoan_he_thong { get; set; }

        public virtual vai_tro vai_tro { get; set; }
    }
}
