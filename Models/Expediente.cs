using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LGCovid.Models
{
    public class Expediente
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="Ingrese su número de empleado")]
        [Display(Name ="Número de empleado?")]
        public string LGIdNumber { get; set; }
        
        [Display(Name ="Sospecha que padece Covid?")]
        public bool SospechaCovid { get; set; }
        
        [Display(Name = "Síntomas")]
        public string Sintomas { get; set; }

        [Display(Name ="Fecha de consulta?")]
        [DataType(DataType.Date)]
        public DateTime? FechaConsulta { get; set; }
        
        [Display(Name ="Lugar de Consulta?")]
        public string LugarConsulta { get; set; }
        
        [Display(Name ="Ya se realizó el test de Covid?")]
        public bool TestCovid { get; set; }

        [Display(Name ="Cuando se lo realizó?")]
        [DataType(DataType.Date)]
        public DateTime?  CuandoSeRealizoTest { get; set; }
        
        [Display(Name ="Donde se lo realizó?")]
        public string  DondeSeRealizo { get; set; }

        [Display(Name ="Resultado del test de Covid?")]
        public string Status { get; set; }

        [Display(Name ="Tiene incapacidad?")]
        public bool Incapacidad { get; set; }

        [Display(Name = "Ingrese su folio de incapacidad")]
        public string FolioIncapacidad { get; set; }

        [Display(Name ="Fecha de inicio de su incapacidad?")]
        [DataType(DataType.Date)]
        public DateTime?  FechaInicioIncapacidad { get; set; }

        [Display(Name ="Cantidad de dias incapacitado?")]
        public int? DiasIncapacidad { get; set; }

        [Display(Name = "Es usted quien padece los síntomas u otro?")]
        public string PacienteSelforOther { get; set; }

        [Required(ErrorMessage ="Ingrese telefono de contacto")]
        [Display(Name = "Teléfono de contacto")]
        public string TelContacto { get; set; }
    }
}