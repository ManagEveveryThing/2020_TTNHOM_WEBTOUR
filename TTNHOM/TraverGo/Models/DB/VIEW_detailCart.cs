namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VIEW_detailCart
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cartID { get; set; }

        [StringLength(25)]
        public string username { get; set; }

        public DateTime? dayADD { get; set; }

        [StringLength(100)]
        public string tenDD { get; set; }

        public int? sl { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        public double? Cost { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maDD { get; set; }
    }
}
