namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA003
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MCRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MCRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MCUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MCUPDTM { get; set; }

   
        [StringLength(6)]
        public string MCIDCD { get; set; }

        [StringLength(20)]
        public string MCIDNM { get; set; }

        [StringLength(1)]
        public string MCSCTLV { get; set; }

        [StringLength(100)]
        public string MCPASS { get; set; }

        [StringLength(4)]
        public string MCSCTNC { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
