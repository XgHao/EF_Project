namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MenuGroup")]
    public partial class MenuGroup
    {
        public int MenuGroupID { get; set; }

        [StringLength(50)]
        public string MenuGroupNo { get; set; }

        [StringLength(50)]
        public string MenuGroupName { get; set; }

        public int? MenuID { get; set; }

        [StringLength(50)]
        public string MenuGroupDesc { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
