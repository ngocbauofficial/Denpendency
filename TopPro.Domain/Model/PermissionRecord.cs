namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermissionRecord")]
    public partial class PermissionRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [StringLength(255)]
        public string SystemName { get; set; }

        [StringLength(255)]
        public string Category { get; set; }
    }
}
