namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InventoryArea
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryAreaID { get; set; }

        [StringLength(232)]
        public string Warehouse { get; set; }

        [StringLength(200)]
        public string InventoryAreaName { get; set; }

        [StringLength(30)]
        public string InventoryAreaNo { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Enable { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string InventoryAreaTypeName { get; set; }

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
