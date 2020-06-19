namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WishList")]
    public partial class WishList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WishList()
        {
            DSKSTrongWLs = new HashSet<DSKSTrongWL>();
            DSTourTrongWLs = new HashSet<DSTourTrongWL>();
        }

        [Key]
        [StringLength(10)]
        public string maWL { get; set; }

        [Required]
        [StringLength(25)]
        public string username { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSKSTrongWL> DSKSTrongWLs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSTourTrongWL> DSTourTrongWLs { get; set; }
    }
}
