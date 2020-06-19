namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TenCacBang")]
    public partial class TenCacBang
    {
        [Key]
        [Column("tenCacBang")]
        [StringLength(100)]
        public string tenCacBang1 { get; set; }

        [StringLength(100)]
        public string chuThich { get; set; }
    }
}
