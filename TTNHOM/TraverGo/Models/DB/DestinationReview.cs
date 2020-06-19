namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DestinationReview")]
    public partial class DestinationReview
    {
        [Key]
        [StringLength(10)]
        public string maDD { get; set; }

        [StringLength(100)]
        public string tenDD { get; set; }

        [StringLength(100)]
        public string tenTinh { get; set; }

        [StringLength(100)]
        public string tenQG { get; set; }

        [StringLength(100)]
        public string pic { get; set; }
    }
}
