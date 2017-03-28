namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.tkb_lich_hoc_theo_ngay")]
    public partial class tkb_lich_hoc_theo_ngay
    {
        public int id { get; set; }

        public DateTime? ngay { get; set; }

        public int giang_duong_id { get; set; }

        public int lop_mon_hoc_id { get; set; }

        public int tkb_thu_id { get; set; }

        public int tkb_tiet_cuoi_cung_id { get; set; }

        public int tkb_tiet_dau_tien_id { get; set; }

        public bool thi_cuoi_ky { get; set; }

        public bool thi_giua_ky { get; set; }

        [StringLength(500)]
        public string giao_vien_nhan { get; set; }

        public virtual giang_duong giang_duong { get; set; }

        public virtual lop_mon_hoc lop_mon_hoc { get; set; }

        public virtual tkb_tiet tkb_tiet { get; set; }

        public virtual tkb_thu tkb_thu { get; set; }

        public virtual tkb_tiet tkb_tiet1 { get; set; }
    }
}
