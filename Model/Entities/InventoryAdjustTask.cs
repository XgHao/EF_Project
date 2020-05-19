namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryAdjustTask")]
    public partial class InventoryAdjustTask
    {
        public int InventoryAdjustTaskID { get; set; }

        [StringLength(30)]
        public string InventoryAdjustTaskNo { get; set; }

        [StringLength(5)]
        public string InventoryAdjustTaskType { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
