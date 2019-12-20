namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA012
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MNRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MNRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MNUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MNUPDTM { get; set; }

        [Required]
        [StringLength(3)]
        public string MNCLSCD { get; set; }

        [StringLength(6)]
        public string MNSRCD { get; set; }

        [StringLength(30)]
        public string MNSRNM { get; set; }

        [StringLength(15)]
        public string MNSRSNM { get; set; }

        public virtual MA001 MA001 { get; set; }
    }
}
