namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Menu()
        {
            MenuGroups = new HashSet<MenuGroup>();
        }

        public int MenuID { get; set; }

        public int? MenuIndex { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        [StringLength(50)]
        public string MenuEName { get; set; }

        public int? MenuNo { get; set; }

        public int? MenuRoot { get; set; }

        [StringLength(50)]
        public string MenuWindowName { get; set; }

        [StringLength(50)]
        public string MenuDesc { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuGroup> MenuGroups { get; set; }
    }
}
