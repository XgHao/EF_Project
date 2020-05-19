namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaterialSizeID { get; set; }

        [StringLength(102)]
        public string MaterialType { get; set; }

        [StringLength(50)]
        public string SizeCode { get; set; }

        [StringLength(80)]
        public string Detail { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        [StringLength(92)]
        public string LWH { get; set; }

        public decimal? Weight { get; set; }

        [StringLength(50)]
        public string MaterialModel { get; set; }

        [StringLength(50)]
        public string ParcelUnit { get; set; }

        public int? ParcelMeasure { get; set; }

        public int? MaterialMin { get; set; }

        public int? MaterialMax { get; set; }

        [StringLength(100)]
        public string ContainerName { get; set; }

        public bool? IsCKD { get; set; }

        public decimal? MaterialDensity { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }
    }
}
