namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PickingTaskDetail")]
    public partial class PickingTaskDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PickingTaskDetail()
        {
            InventoryLocks = new HashSet<InventoryLock>();
        }

        public long PickingTaskDetailID { get; set; }

        public long? PickingTaskID { get; set; }

        public long? WavePickingDetailID { get; set; }

        [StringLength(50)]
        public string SizeCode { get; set; }

        [StringLength(50)]
        public string TrayCode { get; set; }

        public long? TrayDetailID { get; set; }

        public decimal? QuantityAllotted { get; set; }

        public decimal? ActualPickingNum { get; set; }

        public decimal? TrayCount { get; set; }

        public int? Container { get; set; }

        public DateTime? PickingTime { get; set; }

        public int? Picker { get; set; }

        [StringLength(20)]
        public string PickerStation { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual Container Container1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryLock> InventoryLocks { get; set; }

        public virtual PickingTask PickingTask { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual TrayDetail TrayDetail { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }

        public virtual WavePickingDetail WavePickingDetail { get; set; }
    }
}
