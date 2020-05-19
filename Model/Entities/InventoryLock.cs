namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryLock")]
    public partial class InventoryLock
    {
        public long InventoryLockID { get; set; }

        public long? InventoryListID { get; set; }

        public int? InventoryLockType { get; set; }

        public decimal? InventoryLockNum { get; set; }

        public long? TrayDetailID { get; set; }

        public int? Status { get; set; }

        public long? WavePickingDetailID { get; set; }

        public long? PickingTaskDetailID { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual InventoryList InventoryList { get; set; }

        public virtual PickingTaskDetail PickingTaskDetail { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual TrayDetail TrayDetail { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual WavePickingDetail WavePickingDetail { get; set; }
    }
}
