namespace FarmerMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        public int MaTinTuc { get; set; }

        [StringLength(255)]
        public string TieuDe { get; set; }

        [StringLength(300)]
        public string MoTaNgan { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTaChiTiet { get; set; }

        [StringLength(100)]
        public string HinhAnh { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTaiKhoan { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
