namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_User
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserNo { get; set; }

        [StringLength(50)]
        public string UserGroupName { get; set; }

        [StringLength(20)]
        public string UserPhoneNum { get; set; }

        [StringLength(50)]
        public string UserEmail { get; set; }

        [StringLength(50)]
        public string UserDesc { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsChecked { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? ChangeTime { get; set; }

        [StringLength(50)]
        public string ChangerName { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool IsAbandon { get; set; }
    }
}
