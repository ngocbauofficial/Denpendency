namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA006
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MFRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MFRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MFUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MFUPDTM { get; set; }

        [StringLength(25)]
        public string MFPRDSP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MFDNSTY { get; set; }

        [StringLength(10)]
        public string MFRMK10 { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
