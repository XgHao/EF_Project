namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WavePicking")]
    public partial class WavePicking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WavePicking()
        {
            WavePickingDetails = new HashSet<WavePickingDetail>();
        }

        public int WavePickingID { get; set; }

        [StringLength(30)]
        public string WavePickingNo { get; set; }

        public int? WavePickingTypeID { get; set; }

        public int? PickingType { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        public int? Status { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual PickingType PickingType1 { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual WavePickingType WavePickingType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WavePickingDetail> WavePickingDetails { get; set; }
    }
}
