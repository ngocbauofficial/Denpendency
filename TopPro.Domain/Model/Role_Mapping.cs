namespace TopPro.Domain.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role_Mapping
    {
        public int Id { get; set; }

        public int PermissionRecord_Id { get; set; }

        [Required]
        [StringLength(1)]
        public string CustomerRole_Id { get; set; }
    }
}
