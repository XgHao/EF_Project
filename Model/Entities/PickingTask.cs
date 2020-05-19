namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PickingTask")]
    public partial class PickingTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PickingTask()
        {
            PickingTaskDetails = new HashSet<PickingTaskDetail>();
        }

        public long PickingTaskID { get; set; }

        [StringLength(30)]
        public string PickingTaskNo { get; set; }

        public int? PickingTypeID { get; set; }

        [StringLength(30)]
        public string WavePickingNo { get; set; }

        [StringLength(20)]
        public string PickingStation { get; set; }

        public int? Priority { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual PickingTask PickingTask1 { get; set; }

        public virtual PickingTask PickingTask2 { get; set; }

        public virtual PickingType PickingType { get; set; }

        public virtual Status Status1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PickingTaskDetail> PickingTaskDetails { get; set; }
    }
}
