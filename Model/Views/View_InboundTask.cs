namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InboundTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InboundTaskID { get; set; }

        [StringLength(30)]
        public string InboundTaskNo { get; set; }

        [StringLength(50)]
        public string InboundTypeName { get; set; }

        [StringLength(300)]
        public string InboundRemark { get; set; }

        public DateTime? AOGTime { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        [StringLength(30)]
        public string ExterNo { get; set; }

        [StringLength(20)]
        public string OrderNo { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string HtmlAttributes { get; set; }

        public DateTime? TaskCompletionTime { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? InboundTaskDetailID { get; set; }
    }
}
