namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA002
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MBRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MBRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MBUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MBUPDTM { get; set; }


        [StringLength(6)]
        public string MBUSRCD { get; set; }

        [StringLength(36)]
        public string MBUSRNM { get; set; }

        [StringLength(15)]
        public string MBUSSNM { get; set; }

        [StringLength(60)]
        public string MBUSAD1 { get; set; }

        [StringLength(60)]
        public string MBUSAD2 { get; set; }

        [StringLength(60)]
        public string MBUSAD3 { get; set; }

        [StringLength(16)]
        public string MBUSTEL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MBUCC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MBUUC { get; set; }

        [StringLength(1)]
        public string MBWTCAL { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

    

    }
}
