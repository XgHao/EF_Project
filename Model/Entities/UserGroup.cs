namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserGroup")]
    public partial class UserGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserGroup()
        {
            Users = new HashSet<User>();
        }

        public int UserGroupID { get; set; }

        [StringLength(50)]
        public string UserGroupName { get; set; }

        [StringLength(50)]
        public string UserGroupNo { get; set; }

        public int? UserGroupClass { get; set; }

        [StringLength(50)]
        public string MenuGroupCode { get; set; }

        [StringLength(50)]
        public string UserGroupDesc { get; set; }

        public int? Creater { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
