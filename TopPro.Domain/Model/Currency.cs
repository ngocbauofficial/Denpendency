namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Currency")]
    public partial class Currency
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        [Column("currency")]
        [StringLength(100)]
        public string currency1 { get; set; }

        [StringLength(100)]
        public string code { get; set; }

        [StringLength(100)]
        public string symbol { get; set; }
    }
}
