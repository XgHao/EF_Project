namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_TrayDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TrayDetailID { get; set; }

        [StringLength(30)]
        public string InboundTaskNo { get; set; }

        [StringLength(155)]
        public string MaterialSizeInfo { get; set; }

        [StringLength(50)]
        public string TrayNo { get; set; }

        [StringLength(50)]
        public string TrayCode { get; set; }

        public int? GroupTrayOrder { get; set; }

        public decimal? ParcelMeasure { get; set; }

        [StringLength(100)]
        public string ContainerName { get; set; }

        public decimal? Weight { get; set; }

        [StringLength(50)]
        public string MaterialSN { get; set; }

        public int? MaterialDateVersion { get; set; }

        public int? InboundPostMark { get; set; }

        public int? OutboundPostMark { get; set; }

        public DateTime? ProductionDate { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string HtmlAttributes { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }
    }
}
