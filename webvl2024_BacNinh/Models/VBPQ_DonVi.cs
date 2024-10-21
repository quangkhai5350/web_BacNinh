namespace webvl2024_BacNinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VBPQ_DonVi
    {
        public VBPQ_DonVi()
        {
            this.VBPQ_TaiLieus = new HashSet<VBPQ_TaiLieu>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string TenDonVi { get; set; }

        public int NguoiNhap { get; set; }

        public DateTime NgayNhap { get; set; }

        public bool IsActive { get; set; }

        public int OrderNumber { get; set; }

        [StringLength(2000)]
        public string MoTa { get; set; }

        public int PortalId { get; set; }

        public int ModuleId { get; set; }

        public Guid msrepl_tran_version { get; set; }
        public virtual ICollection<VBPQ_TaiLieu> VBPQ_TaiLieus { get; set; }
    }
}
