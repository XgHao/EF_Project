namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_WavePicking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WavePickingID { get; set; }

        [StringLength(30)]
        public string WavePickingNo { get; set; }

        [StringLength(50)]
        public string WavePickingTypeName { get; set; }

        [StringLength(50)]
        public string PickingName { get; set; }

        [StringLength(300)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string StatusName { get; set; }

        [StringLength(50)]
        public string CreaterName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime? ChangeTime { get; set; }

        public int? DataVersion { get; set; }

        public long? WavePickingDetailID { get; set; }
    }
}
