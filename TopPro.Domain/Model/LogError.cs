namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogError")]
    public partial class LogError
    {
        public int ID { get; set; }

        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "ntext")]
        public string ExceptionSource { get; set; }

        [Column(TypeName = "ntext")]
        public string ExceptionMsg { get; set; }

        [StringLength(250)]
        public string ExceptionType { get; set; }

        [StringLength(50)]
        public string UserCreate { get; set; }

        [StringLength(250)]
        public string ExceptionURL { get; set; }
    }
}
