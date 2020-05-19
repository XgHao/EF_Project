namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InventoryLocation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryLocationID { get; set; }

        [StringLength(232)]
        public string InventoryArea { get; set; }

        [StringLength(10)]
        public string InventoryLocationType { get; set; }

        [StringLength(200)]
        public string InventoryLocationName { get; set; }

        [StringLength(30)]
        public string InventoryLocationNo { get; set; }

        [StringLength(96)]
        public string LWH { get; set; }

        [StringLength(96)]
        public string PLC { get; set; }

        [StringLength(50)]
        public string InventoryLocationGroupName { get; set; }

        [StringLength(100)]
        public string NarrowName { get; set; }

        [StringLength(63)]
        public string EnterExitDistance { get; set; }

        public int? FrontAndBack { get; set; }

        [StringLength(100)]
        public string ContainerName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Enable { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }
    }
}
