namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSTourTrongWL")]
    public partial class DSTourTrongWL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maTour { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maWL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayAdd { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual WishList WishList { get; set; }
    }
}
