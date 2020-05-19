namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryAllocation")]
    public partial class InventoryAllocation
    {
        public int InventoryAllocationID { get; set; }

        public int? MaterialTypeID { get; set; }

        public int? InventoryLocationID { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual MaterialType MaterialType { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
