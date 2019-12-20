namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA004
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MDRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MDRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MDUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MDUPDTM { get; set; }

        [StringLength(6)]
        public string MDLCTCD { get; set; }

        [StringLength(1)]
        public string MDWRCTG { get; set; }

        [StringLength(20)]
        public string MDLCTNM { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public virtual WareHouse WareHouse { get; set; }
    }
}
