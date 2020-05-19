namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryAdjustTaskDetail")]
    public partial class InventoryAdjustTaskDetail
    {
        public int InventoryAdjustTaskDetailID { get; set; }

        [StringLength(30)]
        public string InventoryAdjustTaskDetailNo { get; set; }

        public int? InventoryAreaID { get; set; }

        public long? TrayDetailID { get; set; }

        public int? MaterialSizeID { get; set; }

        public decimal? OldNum { get; set; }

        public decimal? NowNum { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual TrayDetail TrayDetail { get; set; }

        public virtual InventoryArea InventoryArea { get; set; }

        public virtual Material Material { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
