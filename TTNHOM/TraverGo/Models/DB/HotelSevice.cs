namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelSevice")]
    public partial class HotelSevice
    {
        [Key]
        [StringLength(10)]
        public string IDHotel { get; set; }

        [StringLength(50)]
        public string NameHotel { get; set; }

        public int? PriceHotel { get; set; }

        [StringLength(50)]
        public string AddressHotel { get; set; }

        public int? Reviews { get; set; }

        [StringLength(50)]
        public string ContentHotel { get; set; }

        [StringLength(50)]
        public string Urlimage { get; set; }
    }
}
