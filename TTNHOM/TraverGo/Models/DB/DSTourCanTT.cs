namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DSTourCanTT")]
    public partial class DSTourCanTT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maTour { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maHD { get; set; }

        public double? cost { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public virtual ElecBill ElecBill { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
