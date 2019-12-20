namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityLevel")]
    public partial class SecurityLevel
    {
        [StringLength(1)]
        public string Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
    }
}
