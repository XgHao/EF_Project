namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckTask")]
    public partial class CheckTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckTask()
        {
            CheckTask1 = new HashSet<CheckTask>();
            CheckTaskDetails = new HashSet<CheckTaskDetail>();
        }

        public int CheckTaskID { get; set; }

        public int? RelCheckTaskID { get; set; }

        public int? CheckTaskType { get; set; }

        [StringLength(30)]
        public string CheckTaskNo { get; set; }

        public DateTime? CheckTaskDate { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckTask> CheckTask1 { get; set; }

        public virtual CheckTask CheckTask2 { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckTaskDetail> CheckTaskDetails { get; set; }
    }
}
