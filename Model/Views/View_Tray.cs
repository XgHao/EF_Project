namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Tray
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TrayID { get; set; }

        [StringLength(50)]
        public string TrayTypeName { get; set; }

        [StringLength(50)]
        public string TrayNo { get; set; }

        [StringLength(50)]
        public string TrayCode { get; set; }

        [StringLength(100)]
        public string ContainerName { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string HtmlAttributes { get; set; }

        public DateTime? InboundTime { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public long? TrayDetailID { get; set; }
    }
}
