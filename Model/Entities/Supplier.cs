namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            InboundTasks = new HashSet<InboundTask>();
            MaterialTypes = new HashSet<MaterialType>();
        }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierNo { get; set; }

        [StringLength(50)]
        public string SupplierName { get; set; }

        [StringLength(20)]
        public string SupplierPhoNum { get; set; }

        [StringLength(30)]
        public string SupplierEmail { get; set; }

        [StringLength(100)]
        public string SupplierRemark { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public bool IsAbandon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundTask> InboundTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialType> MaterialTypes { get; set; }
    }
}
