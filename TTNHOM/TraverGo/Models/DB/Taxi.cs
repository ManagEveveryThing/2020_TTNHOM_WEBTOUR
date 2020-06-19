namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taxi")]
    public partial class Taxi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taxi()
        {
            DSDatXes = new HashSet<DSDatXe>();
        }

        [Key]
        [StringLength(15)]
        public string bienSo { get; set; }

        [Required]
        [StringLength(10)]
        public string maDD { get; set; }

        public int? soGhe { get; set; }

        [StringLength(10)]
        public string phoneNum { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSDatXe> DSDatXes { get; set; }

        public virtual TourDestination TourDestination { get; set; }
    }
}
