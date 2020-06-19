namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElecBill")]
    public partial class ElecBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ElecBill()
        {
            DSDatXes = new HashSet<DSDatXe>();
            DSKSCanTTs = new HashSet<DSKSCanTT>();
            DSTourCanTTs = new HashSet<DSTourCanTT>();
        }

        [Key]
        [StringLength(10)]
        public string maHD { get; set; }

        [Required]
        [StringLength(25)]
        public string username { get; set; }

        public double? tongTien { get; set; }

        [StringLength(25)]
        public string paymentMethod { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dayCreate { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSDatXe> DSDatXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSKSCanTT> DSKSCanTTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSTourCanTT> DSTourCanTTs { get; set; }
    }
}
