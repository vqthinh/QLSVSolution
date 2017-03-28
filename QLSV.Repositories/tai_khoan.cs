namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.tai_khoan")]
    public partial class tai_khoan
    {
        public int id { get; set; }

        [StringLength(20)]
        public string ten_dang_nhap { get; set; }

        [StringLength(45)]
        public string mat_khau { get; set; }

        public int? loai_nguoi_dung { get; set; }

        public int? id_nguoi_dung { get; set; }

        [Column(TypeName = "bit")]
        public bool? deleted { get; set; }
    }
}
