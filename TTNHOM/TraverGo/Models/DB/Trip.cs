namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trip")]
    public partial class Trip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip()
        {
            DSKSTheoTrips = new HashSet<DSKSTheoTrip>();
            DSTripTheoTours = new HashSet<DSTripTheoTour>();
        }

        [Key]
        [StringLength(10)]
        public string maCD { get; set; }

        [Required]
        [StringLength(10)]
        public string maDDStart { get; set; }

        [Required]
        [StringLength(10)]
        public string maDDEnd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dayStrat { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSKSTheoTrip> DSKSTheoTrips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSTripTheoTour> DSTripTheoTours { get; set; }

        public virtual TourDestination TourDestination { get; set; }

        public virtual TourDestination TourDestination1 { get; set; }
    }
}
