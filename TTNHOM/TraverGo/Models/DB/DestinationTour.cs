namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DestinationTour")]
    public partial class DestinationTour
    {
        [Key]
        [StringLength(10)]
        public string maDD { get; set; }

        [StringLength(100)]
        public string tenDD { get; set; }

        [StringLength(100)]
        public string tenQG { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(500)]
        public string moTa { get; set; }

        [StringLength(100)]
        public string near { get; set; }

        public int? countHomeStay { get; set; }

        public int? countTaxi { get; set; }

        [StringLength(100)]
        public string tenTinh { get; set; }

        public int? countTour { get; set; }

        public double? Cost { get; set; }
    }
}
