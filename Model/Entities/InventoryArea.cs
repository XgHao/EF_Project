namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryArea")]
    public partial class InventoryArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryArea()
        {
            InventoryAdjustTaskDetails = new HashSet<InventoryAdjustTaskDetail>();
            InventoryLocations = new HashSet<InventoryLocation>();
        }

        public int InventoryAreaID { get; set; }

        public int? WarehouseID { get; set; }

        [StringLength(30)]
        public string InventoryAreaNo { get; set; }

        [StringLength(200)]
        public string InventoryAreaName { get; set; }

        public bool Enable { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int? InventoryAreaType { get; set; }

        [StringLength(200)]
        public string OtherInfo { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAdjustTaskDetail> InventoryAdjustTaskDetails { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        public virtual InventoryAreaType InventoryAreaType1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryLocation> InventoryLocations { get; set; }
    }
}
