namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundType")]
    public partial class InboundType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InboundType()
        {
            InboundTasks = new HashSet<InboundTask>();
        }

        public int InboundTypeID { get; set; }

        [StringLength(50)]
        public string InboundTypeName { get; set; }

        public bool IsAbandon { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(50)]
        public string Other { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundTask> InboundTasks { get; set; }

        public virtual InboundType InboundType1 { get; set; }

        public virtual InboundType InboundType2 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
