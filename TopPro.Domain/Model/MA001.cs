namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA001
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MARGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MARGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAUPDTM { get; set; }

        [StringLength(6)]
        public string MASPCD { get; set; }

        [StringLength(36)]
        public string MASPNM { get; set; }

        [StringLength(15)]
        public string MASPSNM { get; set; }

        [StringLength(60)]
        public string MASPAD1 { get; set; }

        [StringLength(60)]
        public string MASPAD2 { get; set; }

        [StringLength(60)]
        public string MASPAD3 { get; set; }

        [StringLength(4)]
        public string MACNTRC { get; set; }

        [StringLength(16)]
        public string MASPTEL { get; set; }

        [StringLength(16)]
        public string MASPFAX { get; set; }

        [StringLength(4)]
        public string MABUZCD { get; set; }

        [StringLength(6)]
        public string MAIDCD { get; set; }

        [StringLength(1)]
        public string MASPCTG { get; set; }

        [StringLength(6)]
        public string MASTDUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MASCLSD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MASDFER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MASSETL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MACLTRM { get; set; }

        [StringLength(6)]
        public string MASDAYS { get; set; }

        [StringLength(3)]
        public string MASCRCD { get; set; }

        [StringLength(2)]
        public string MASTXCD { get; set; }

        [StringLength(6)]
        public string MASCALC { get; set; }

        [StringLength(6)]
        public string MAPTDUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAPCLSD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAPDFER { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAPSETL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MAPYTRM { get; set; }

        [StringLength(6)]
        public string MAPDAYS { get; set; }

        [StringLength(3)]
        public string MAPCRCD { get; set; }

        [StringLength(2)]
        public string MAPTXCD { get; set; }

        [StringLength(6)]
        public string MAPCALC { get; set; }

        public bool? Status { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
  
    }
}
