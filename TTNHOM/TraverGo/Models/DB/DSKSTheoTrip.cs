namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSKSTheoTrip")]
    public partial class DSKSTheoTrip
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maCD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maKS { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public virtual HomeStay HomeStay { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
