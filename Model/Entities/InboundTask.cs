namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundTask")]
    public partial class InboundTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InboundTask()
        {
            InboundTaskDetails = new HashSet<InboundTaskDetail>();
        }

        public int InboundTaskID { get; set; }

        [StringLength(30)]
        public string InboundTaskNo { get; set; }

        public int? InboundType { get; set; }

        [StringLength(300)]
        public string InboundRemark { get; set; }

        public DateTime? AOGTime { get; set; }

        public int? SupplierID { get; set; }

        [StringLength(30)]
        public string ExterNo { get; set; }

        [StringLength(20)]
        public string OrderNo { get; set; }

        public int? Status { get; set; }

        public DateTime? TaskCompletionTime { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual InboundType InboundType1 { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundTaskDetail> InboundTaskDetails { get; set; }
    }
}
