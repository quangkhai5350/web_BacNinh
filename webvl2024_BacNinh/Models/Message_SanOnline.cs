namespace webvl2024_BacNinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message_SanOnline
    {
        [Key]
        public int ID_TinNhan { get; set; }

        public string TinNhan_Text { get; set; }

        public string TinNhan_File { get; set; }

        public int User_Gui { get; set; }

        public int User_Nhan { get; set; }

        public int? PhienId { get; set; }

        public DateTime? NgayTao { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(61)]
        public string group_chat { get; set; }

        public bool? Status { get; set; }
    }
}
