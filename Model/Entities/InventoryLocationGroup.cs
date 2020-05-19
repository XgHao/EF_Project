namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryLocationGroup")]
    public partial class InventoryLocationGroup
    {
        public int InventoryLocationGroupID { get; set; }

        [StringLength(50)]
        public string InventoryLocationGroupName { get; set; }
    }
}
