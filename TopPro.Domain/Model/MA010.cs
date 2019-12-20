namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA010
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MKRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MKRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MKUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MKUPDTM { get; set; }


        [StringLength(2)]
        public string MKTXCD { get; set; }

        [StringLength(15)]
        public string MKTXDL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MKTXRT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MKFRDT { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
