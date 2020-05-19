namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InboundTaskDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InboundTaskDetailID { get; set; }

        [StringLength(30)]
        public string InboundTaskNo { get; set; }

        [StringLength(155)]
        public string MaterialSizeInfo { get; set; }

        public decimal? MaterialNum { get; set; }

        public decimal? Weight { get; set; }

        [StringLength(30)]
        public string BatchNumber { get; set; }

        [StringLength(100)]
        public string DeliveryUnit { get; set; }

        [StringLength(10)]
        public string CarNum { get; set; }

        [StringLength(20)]
        public string Glaze { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public decimal? ActualInboundNum { get; set; }

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
    }
}
