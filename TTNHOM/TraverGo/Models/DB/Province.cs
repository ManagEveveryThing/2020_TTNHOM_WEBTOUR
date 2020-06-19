namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Province")]
    public partial class Province
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Province()
        {
            TourDestinations = new HashSet<TourDestination>();
        }

        [Key]
        [StringLength(10)]
        public string maTinh { get; set; }

        [Required]
        [StringLength(10)]
        public string maQG { get; set; }

        [StringLength(100)]
        public string tenTinh { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(500)]
        public string moTa { get; set; }

        public virtual Nation Nation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourDestination> TourDestinations { get; set; }
    }
}
