namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WavePickingDetail")]
    public partial class WavePickingDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WavePickingDetail()
        {
            InventoryLocks = new HashSet<InventoryLock>();
            PickingTaskDetails = new HashSet<PickingTaskDetail>();
        }

        public long WavePickingDetailID { get; set; }

        public int? WavePickingID { get; set; }

        public int? OutboundTaskDetailID { get; set; }

        public int? MaterialSizeID { get; set; }

        public decimal? MaterialNum { get; set; }

        [StringLength(30)]
        public string BatchNumber { get; set; }

        public long? TrayDetailID { get; set; }

        public long? InventoryID { get; set; }

        [StringLength(20)]
        public string Glaze { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        public decimal? QuantityAllotted { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual InventoryList InventoryList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryLock> InventoryLocks { get; set; }

        public virtual Material Material { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickingTaskDetail> PickingTaskDetails { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual TrayDetail TrayDetail { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual WavePicking WavePicking { get; set; }
    }
}
