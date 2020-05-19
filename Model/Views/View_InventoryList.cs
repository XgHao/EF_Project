namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InventoryList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long InventoryListID { get; set; }

        [StringLength(10)]
        public string InventoryType { get; set; }

        [StringLength(30)]
        public string InboundTaskNo { get; set; }

        [StringLength(30)]
        public string OutboundTaskNo { get; set; }

        [StringLength(103)]
        public string TrayNoAndCode { get; set; }

        [StringLength(30)]
        public string InventoryLocationNo { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }
    }
}
