namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutboundTaskDetail")]
    public partial class OutboundTaskDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OutboundTaskDetail()
        {
            InventoryLists = new HashSet<InventoryList>();
        }

        public int OutboundTaskDetailID { get; set; }

        public int? OutboundTaskID { get; set; }

        public int? MaterialSizeID { get; set; }

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

        public decimal? QuantityAllotted { get; set; }

        public decimal? DispatchNum { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryList> InventoryLists { get; set; }

        public virtual OutboundTask OutboundTask { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
