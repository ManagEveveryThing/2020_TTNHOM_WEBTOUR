namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("detailService")]
    public partial class detailService
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maKS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maDD { get; set; }

        [StringLength(50)]
        public string tenKS { get; set; }

        [StringLength(10)]
        public string phoneNum { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        [StringLength(500)]
        public string moTa { get; set; }

        public int? numReview { get; set; }

        public int? costPerNight { get; set; }

        [StringLength(100)]
        public string tenDD { get; set; }

        [StringLength(100)]
        public string tenQG { get; set; }

        [StringLength(100)]
        public string tenTinh { get; set; }
    }
}
