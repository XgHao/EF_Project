namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckTaskDetail")]
    public partial class CheckTaskDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheckTaskDetailID { get; set; }

        public int? CheckTaskID { get; set; }

        public int? InventoryLocationID { get; set; }

        public int? MaterialSizeID { get; set; }

        public decimal? MaterialNum { get; set; }

        public long? TrayDetailID { get; set; }

        [StringLength(20)]
        public string PickingStation { get; set; }

        public decimal? ActualNum { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual CheckTask CheckTask { get; set; }

        public virtual InventoryLocation InventoryLocation { get; set; }

        public virtual Material Material { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual TrayDetail TrayDetail { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
