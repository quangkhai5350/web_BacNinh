namespace webvl2024_BacNinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_TinhTrangHSHocNghe
    {
        [Key]
        public int TinhTrangHSHocNghe_ID { get; set; }

        [StringLength(50)]
        public string TenTinhTrangHSHN { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? NguoiTao { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }
    }
}
