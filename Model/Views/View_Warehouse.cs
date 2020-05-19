namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Warehouse
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarehouseID { get; set; }

        [StringLength(30)]
        public string WarehouseNo { get; set; }

        [StringLength(200)]
        public string WarehouseName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Enable { get; set; }

        [StringLength(20)]
        public string WarehouseType { get; set; }

        [StringLength(200)]
        public string OtherInfo { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }
    }
}
