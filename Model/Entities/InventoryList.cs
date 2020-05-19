namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryList")]
    public partial class InventoryList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryList()
        {
            InventoryLocks = new HashSet<InventoryLock>();
            WavePickingDetails = new HashSet<WavePickingDetail>();
        }

        public long InventoryListID { get; set; }

        public int? InboundTaskDetailID { get; set; }

        public int? OutboundTaskDetailID { get; set; }

        [StringLength(10)]
        public string InventoryType { get; set; }

        public long? TrayID { get; set; }

        public int? InventoryLocationID { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual InboundTaskDetail InboundTaskDetail { get; set; }

        public virtual OutboundTaskDetail OutboundTaskDetail { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryLock> InventoryLocks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WavePickingDetail> WavePickingDetails { get; set; }
    }
}
