namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warehouse")]
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            InventoryAreas = new HashSet<InventoryArea>();
        }

        public int WarehouseID { get; set; }

        [StringLength(30)]
        public string WarehouseNo { get; set; }

        [StringLength(200)]
        public string WarehouseName { get; set; }

        public bool Enable { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [StringLength(20)]
        public string WarehouseType { get; set; }

        [StringLength(200)]
        public string OtherInfo { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryArea> InventoryAreas { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
