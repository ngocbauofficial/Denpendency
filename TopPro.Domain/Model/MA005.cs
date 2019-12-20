namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA005
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MERGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MERGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MEUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MEUPDTM { get; set; }

        [StringLength(5)]
        public string MECOAT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MECOATW { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
