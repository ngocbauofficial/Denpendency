namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA009
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJRGSDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJRGSTM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJUPDT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJUPDTM { get; set; }

        [Required]
        [StringLength(3)]
        public string MJCRRCD { get; set; }

        [StringLength(2)]
        public string MJEXRTT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJEXRTD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJEXRT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MJTXEXR { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }
    }
}
