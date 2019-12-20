namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA011
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MLRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MLRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MLUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MLUPDTM { get; set; }

        [StringLength(6)]
        public string MLCSTCD { get; set; }

        [StringLength(1)]
        public string MLCRDRK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MLVLDTR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MLCRDLM { get; set; }
    }
}
