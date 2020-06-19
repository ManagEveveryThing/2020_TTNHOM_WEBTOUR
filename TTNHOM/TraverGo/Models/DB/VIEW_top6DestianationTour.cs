namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VIEW_top6DestianationTour
    {
        [Key]
        [StringLength(10)]
        public string maDD { get; set; }

        [StringLength(100)]
        public string tenDD { get; set; }

        [StringLength(100)]
        public string tenTinh { get; set; }

        [StringLength(100)]
        public string near { get; set; }

        public int? countHomeStay { get; set; }

        public int? countTaxi { get; set; }

        public int? countWL { get; set; }

        public int? countTour { get; set; }
    }
}
