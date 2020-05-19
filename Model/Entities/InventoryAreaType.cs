namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryAreaType")]
    public partial class InventoryAreaType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryAreaType()
        {
            InventoryAreas = new HashSet<InventoryArea>();
        }

        public int InventoryAreaTypeID { get; set; }

        [StringLength(50)]
        public string InventoryAreaTypeName { get; set; }

        public bool IsAbandon { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(50)]
        public string Other { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryArea> InventoryAreas { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
