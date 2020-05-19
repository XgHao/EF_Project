namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrayDetail")]
    public partial class TrayDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrayDetail()
        {
            CheckTaskDetails = new HashSet<CheckTaskDetail>();
            InventoryAdjustTaskDetails = new HashSet<InventoryAdjustTaskDetail>();
            InventoryLocks = new HashSet<InventoryLock>();
            PickingTaskDetails = new HashSet<PickingTaskDetail>();
            WavePickingDetails = new HashSet<WavePickingDetail>();
        }

        public long TrayDetailID { get; set; }

        public int? InboundTaskDetailID { get; set; }

        public long? TrayID { get; set; }

        public int? GroupTrayOrder { get; set; }

        public int? MaterialSizeID { get; set; }

        public decimal? ParcelMeasure { get; set; }

        [StringLength(50)]
        public string MaterialSN { get; set; }

        public int? InboundPostMark { get; set; }

        public int? OutboundPostMark { get; set; }

        public DateTime? ProductionDate { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckTaskDetail> CheckTaskDetails { get; set; }

        public virtual InboundTaskDetail InboundTaskDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAdjustTaskDetail> InventoryAdjustTaskDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryLock> InventoryLocks { get; set; }

        public virtual Material Material { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickingTaskDetail> PickingTaskDetails { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual Tray Tray { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WavePickingDetail> WavePickingDetails { get; set; }
    }
}
