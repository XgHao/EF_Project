namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InventoryAreaType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryAreaTypeID { get; set; }

        [StringLength(50)]
        public string InventoryAreaTypeName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsAbandon { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        [StringLength(50)]
        public string Other { get; set; }
    }
}
