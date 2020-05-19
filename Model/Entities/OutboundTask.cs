namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutboundTask")]
    public partial class OutboundTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OutboundTask()
        {
            OutboundTaskDetails = new HashSet<OutboundTaskDetail>();
        }

        public int OutboundTaskID { get; set; }

        [StringLength(30)]
        public string OutboundTaskNo { get; set; }

        public int? OutboundType { get; set; }

        [StringLength(300)]
        public string OutboundRemark { get; set; }

        [StringLength(50)]
        public string Client { get; set; }

        [StringLength(30)]
        public string ExterNo { get; set; }

        [StringLength(20)]
        public string SaleNo { get; set; }

        public int? SaleTypeID { get; set; }

        [StringLength(30)]
        public string Department { get; set; }

        public int? Status { get; set; }

        public DateTime? TaskCompletionTime { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual OutboundType OutboundType1 { get; set; }

        public virtual SaleType SaleType { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutboundTaskDetail> OutboundTaskDetails { get; set; }
    }
}
