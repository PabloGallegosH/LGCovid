using LGCovid.Models.Data;
using System;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;

namespace LGCovid.Logic
{
    public class ExpedientesLogic
    {

        public void AddExpediente(Models.Expediente expediente)
        {
            using (Super db = new Super())
            {
                Expediente exp = new Expediente();
                exp.LGIdNumber = expediente.LGIdNumber;
                exp.SospechaCovid = expediente.SospechaCovid;
                exp.Sintomas = expediente.Sintomas;
                exp.FechaConsulta = expediente.FechaConsulta;
                exp.LugarConsulta = expediente.LugarConsulta;
                exp.TestCovid = expediente.TestCovid;
                exp.CuandoSeRealizoTest = expediente.CuandoSeRealizoTest;
                exp.DondeSeRealizo = expediente.DondeSeRealizo;
                exp.Status = expediente.Status;
                exp.Incapacidad = expediente.Incapacidad;
                exp.FolioIncapacidad = expediente.FolioIncapacidad;
                exp.FechaInicioIncapacidad = expediente.FechaInicioIncapacidad;
                exp.DiasIncapacidad = expediente.DiasIncapacidad;
                exp.PacienteSelforOther = expediente.PacienteSelforOther;
                exp.TelContacto = expediente.TelContacto;
                exp.LastChangeDate = DateTime.Now;
                exp.LastChangeUser = "OnlyTest User";
                db.Expedientes.Add(exp);
                db.SaveChanges();
            }
        }


        public bool IsLoginNameExist(string loginName)
        {
            using (Super db = new Super())
            {
                return db.Expedientes.Where(o => o.LGIdNumber.Equals(loginName)).Any();
            }
        }

    }
}