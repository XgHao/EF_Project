namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryLocation")]
    public partial class InventoryLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryLocation()
        {
            CheckTaskDetails = new HashSet<CheckTaskDetail>();
        }

        public int InventoryLocationID { get; set; }

        public int? InventoryAreaID { get; set; }

        [StringLength(10)]
        public string InventoryLocationType { get; set; }

        [StringLength(30)]
        public string InventoryLocationNo { get; set; }

        [StringLength(200)]
        public string InventoryLocationName { get; set; }

        public decimal? InventoryLocationLength { get; set; }

        public decimal? InventoryLocationHeight { get; set; }

        public decimal? InventoryLocationWidth { get; set; }

        public int? Row { get; set; }

        public int? Layer { get; set; }

        public int? Line { get; set; }

        public int? InventoryLocationGroup { get; set; }

        public int? InventoryLocationNarrow { get; set; }

        public int? EnterDistance { get; set; }

        public int? ExitDistance { get; set; }

        public int? FrontAndBack { get; set; }

        public int? Container { get; set; }

        public bool Enable { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckTaskDetail> CheckTaskDetails { get; set; }

        public virtual Container Container1 { get; set; }

        public virtual InventoryArea InventoryArea { get; set; }

        public virtual Narrow Narrow { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
