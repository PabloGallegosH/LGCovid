namespace LGCovid.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expediente")]
    public partial class Expediente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string LGIdNumber { get; set; }

        public bool? SospechaCovid { get; set; }

        [StringLength(500)]
        public string Sintomas { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaConsulta { get; set; }

        [StringLength(100)]
        public string LugarConsulta { get; set; }

        public bool? TestCovid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CuandoSeRealizoTest { get; set; }

        [StringLength(200)]
        public string DondeSeRealizo { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool? Incapacidad { get; set; }

        [StringLength(10)]
        public string FolioIncapacidad { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaInicioIncapacidad { get; set; }

        public int? DiasIncapacidad { get; set; }

        [StringLength(50)]
        public string PacienteSelforOther { get; set; }

        [StringLength(50)]
        public string TelContacto { get; set; }

        public DateTime? LastChangeDate { get; set; }

        [StringLength(30)]
        public string LastChangeUser { get; set; }
    }
}
