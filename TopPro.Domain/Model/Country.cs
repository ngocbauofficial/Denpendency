namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [StringLength(3)]
        public string id { get; set; }

        [Required]
        [StringLength(2)]
        public string iso { get; set; }

        [Required]
        [StringLength(80)]
        public string name { get; set; }

        [Required]
        [StringLength(80)]
        public string nicename { get; set; }

        [StringLength(3)]
        public string iso3 { get; set; }

        public short? numcode { get; set; }

        public int phonecode { get; set; }
    }
}
