namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VIEW_top4Nation
    {
        [Key]
        [StringLength(10)]
        public string maQG { get; set; }

        [StringLength(100)]
        public string tenQG { get; set; }

        public int? countTour { get; set; }

        [StringLength(100)]
        public string pic { get; set; }
    }
}
