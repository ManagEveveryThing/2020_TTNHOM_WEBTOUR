namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Carts = new HashSet<Cart>();
            ElecBills = new HashSet<ElecBill>();
            WishLists = new HashSet<WishList>();
        }

        [Key]
        [StringLength(25)]
        public string username { get; set; }

        [StringLength(25)]
        public string pass { get; set; }

        [StringLength(25)]
        public string tenKH { get; set; }

        [StringLength(25)]
        public string hoKH { get; set; }

        [StringLength(10)]
        public string phoneNum { get; set; }

        [StringLength(25)]
        public string email { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(500)]
        public string Feedback { get; set; }

        [StringLength(100)]
        public string Job { get; set; }

        [StringLength(100)]
        public string nameQ { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElecBill> ElecBills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
