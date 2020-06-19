namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            DSTourCanTTs = new HashSet<DSTourCanTT>();
            DSTourTrongWLs = new HashSet<DSTourTrongWL>();
            DSTripTheoTours = new HashSet<DSTripTheoTour>();
        }

        [Key]
        [StringLength(10)]
        public string maTour { get; set; }

        [StringLength(50)]
        public string tenTour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dayStart { get; set; }

        public int? soLuongMax { get; set; }

        public int? soDem { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(500)]
        public string moTa { get; set; }

        public double? Cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSTourCanTT> DSTourCanTTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSTourTrongWL> DSTourTrongWLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSTripTheoTour> DSTripTheoTours { get; set; }
    }
}
