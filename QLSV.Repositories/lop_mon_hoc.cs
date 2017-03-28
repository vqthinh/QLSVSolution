namespace QLSV.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("daotaodn.lop_mon_hoc")]
    public partial class lop_mon_hoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lop_mon_hoc()
        {
            tkb_lich_hoc_theo_ngay = new HashSet<tkb_lich_hoc_theo_ngay>();
            lop_mon_hoc_sinh_vien = new HashSet<lop_mon_hoc_sinh_vien>();
        }

        public int id { get; set; }

        public int so_tiet_ly_thuyet { get; set; }

        public int so_tiet_thuc_hanh { get; set; }

        public int giao_vien_id { get; set; }

        public int ki_hoc_nam_hoc_id { get; set; }

        public int mon_hoc_id { get; set; }

        public int? so_tin_chi { get; set; }

        public int? ngay_hoc_1 { get; set; }

        public int? ngay_hoc_2 { get; set; }

        [StringLength(1073741823)]
        public string tiet_hoc_1 { get; set; }

        [StringLength(1073741823)]
        public string tiet_hoc_2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_bat_dau { get; set; }

        public int? so_luong_toi_da { get; set; }

        public int? so_luong_dang_ky { get; set; }

        public bool? deleted { get; set; }

        public virtual giao_vien giao_vien { get; set; }

        public virtual ki_hoc_nam_hoc ki_hoc_nam_hoc { get; set; }

        public virtual mon_hoc mon_hoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tkb_lich_hoc_theo_ngay> tkb_lich_hoc_theo_ngay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lop_mon_hoc_sinh_vien> lop_mon_hoc_sinh_vien { get; set; }
    }
}
