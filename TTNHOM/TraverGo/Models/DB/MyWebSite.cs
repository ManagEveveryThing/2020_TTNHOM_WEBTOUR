namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MyWebSite")]
    public partial class MyWebSite
    {
        [Key]
        [StringLength(100)]
        public string nameWeb { get; set; }

        [StringLength(200)]
        public string logo { get; set; }

        [StringLength(10)]
        public string phoneNum1 { get; set; }

        [StringLength(10)]
        public string phoneNum2 { get; set; }

        [StringLength(300)]
        public string addressCompany { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(100)]
        public string fb { get; set; }

        [StringLength(100)]
        public string tw { get; set; }
    }
}
