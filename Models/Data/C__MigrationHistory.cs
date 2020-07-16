namespace LGCovid.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C__MigrationHistory
    {
        [StringLength(150)]
        public string MigrationId { get; set; }

        [StringLength(300)]
        public string ContextKey { get; set; }

        [Key]
        [Column(Order = 0)]
        [MaxLength(50)]
        public byte[] Model { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string ProductVersion { get; set; }
    }
}
