namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailCart")]
    public partial class DetailCart
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cartID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string desTourID { get; set; }

        public DateTime? dayADD { get; set; }

        public int? sl { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual TourDestination TourDestination { get; set; }
    }
}
