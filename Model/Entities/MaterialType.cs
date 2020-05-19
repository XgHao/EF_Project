namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialType")]
    public partial class MaterialType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaterialType()
        {
            InventoryAllocations = new HashSet<InventoryAllocation>();
            Materials = new HashSet<Material>();
            MaterialType1 = new HashSet<MaterialType>();
        }

        public int MaterialTypeID { get; set; }

        [StringLength(50)]
        public string MaterialTypeNo { get; set; }

        [StringLength(50)]
        public string MaterialTypeName { get; set; }

        public int? MaterialTypeRoot { get; set; }

        public int? SupplierID { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public decimal? MaterialTypePrice { get; set; }

        public bool IsAbandon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAllocation> InventoryAllocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materials { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialType> MaterialType1 { get; set; }

        public virtual MaterialType MaterialType2 { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
