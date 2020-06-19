namespace TraverGo.Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("colName")]
    public partial class colName
    {
        [StringLength(128)]
        public string COLUMN_NAME { get; set; }

        [Key]
        public string TABLE_NAME { get; set; }

        public int? ORDINAL_POSITION { get; set; }
    }
}
