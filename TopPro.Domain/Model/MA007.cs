namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA007
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MHRGDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MHRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MHUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MHUPDTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MHBKMNT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MHCLSDT { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
