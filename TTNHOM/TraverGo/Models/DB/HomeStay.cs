namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HomeStay")]
    public partial class HomeStay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HomeStay()
        {
            DSKSCanTTs = new HashSet<DSKSCanTT>();
            DSKSTheoTrips = new HashSet<DSKSTheoTrip>();
            DSKSTrongWLs = new HashSet<DSKSTrongWL>();
        }

        [Key]
        [StringLength(10)]
        public string maKS { get; set; }

        [Required]
        [StringLength(10)]
        public string maDD { get; set; }

        [StringLength(50)]
        public string tenKS { get; set; }

        [StringLength(10)]
        public string phoneNum { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(500)]
        public string moTa { get; set; }

        public int? numReview { get; set; }

        public int? costPerNight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSKSCanTT> DSKSCanTTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSKSTheoTrip> DSKSTheoTrips { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSKSTrongWL> DSKSTrongWLs { get; set; }

        public virtual TourDestination TourDestination { get; set; }
    }
}
