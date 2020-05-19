namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OutboundTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutboundTaskID { get; set; }

        [StringLength(30)]
        public string OutboundTaskNo { get; set; }

        [StringLength(50)]
        public string OutboundTypeName { get; set; }

        [StringLength(300)]
        public string OutboundRemark { get; set; }

        [StringLength(50)]
        public string Client { get; set; }

        [StringLength(30)]
        public string ExterNo { get; set; }

        [StringLength(20)]
        public string SaleNo { get; set; }

        [StringLength(50)]
        public string SaleTypeName { get; set; }

        [StringLength(30)]
        public string Department { get; set; }

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

        public int? DataVersion { get; set; }

        public int? OutboundTaskDetailID { get; set; }
    }
}
