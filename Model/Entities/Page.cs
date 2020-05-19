namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Page")]
    public partial class Page
    {
        public int PageID { get; set; }

        [StringLength(100)]
        public string PageUrl { get; set; }

        [StringLength(50)]
        public string PageName { get; set; }

        public int? PageClass { get; set; }

        public string BlackList { get; set; }

        public string WhiteList { get; set; }

        public int? Changer { get; set; }

        public DateTime? ChangeTime { get; set; }
    }
}
