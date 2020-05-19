namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            CheckTaskDetails = new HashSet<CheckTaskDetail>();
            InboundTaskDetails = new HashSet<InboundTaskDetail>();
            InventoryAdjustTaskDetails = new HashSet<InventoryAdjustTaskDetail>();
            TrayDetails = new HashSet<TrayDetail>();
            WavePickingDetails = new HashSet<WavePickingDetail>();
        }

        [Key]
        public int MaterialSizeID { get; set; }

        public int? MaterialTypeID { get; set; }

        [StringLength(50)]
        public string SizeCode { get; set; }

        [StringLength(80)]
        public string Detail { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        public decimal? Length { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        public decimal? Weight { get; set; }

        [StringLength(50)]
        public string MaterialModel { get; set; }

        [StringLength(50)]
        public string ParcelUnit { get; set; }

        public int? ParcelMeasure { get; set; }

        public int? MaterialMin { get; set; }

        public int? MaterialMax { get; set; }

        public int? MaterialContainer { get; set; }

        public bool? IsCKD { get; set; }

        public decimal? MaterialDensity { get; set; }

        public int? DataVersion { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public bool IsAbandon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckTaskDetail> CheckTaskDetails { get; set; }

        public virtual Container Container { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InboundTaskDetail> InboundTaskDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAdjustTaskDetail> InventoryAdjustTaskDetails { get; set; }

        public virtual MaterialType MaterialType { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrayDetail> TrayDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WavePickingDetail> WavePickingDetails { get; set; }
    }
}
