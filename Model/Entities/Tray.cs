namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tray")]
    public partial class Tray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tray()
        {
            TrayDetails = new HashSet<TrayDetail>();
        }

        public long TrayID { get; set; }

        public int? TrayType { get; set; }

        [StringLength(50)]
        public string TrayNo { get; set; }

        [StringLength(50)]
        public string TrayCode { get; set; }

        public int? Container { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        public int? Status { get; set; }

        public DateTime? InboundTime { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public virtual Container Container1 { get; set; }

        public virtual Status Status1 { get; set; }

        public virtual TrayType TrayType1 { get; set; }

        public virtual TrayType TrayType2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrayDetail> TrayDetails { get; set; }
    }
}
