using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LGCovid.Models.Data;

namespace LGCovid.Controllers
{
    public class ExpedienteController : Controller
    {
        private Super db = new Super();

        // GET: Expediente
        public async Task<ActionResult> Index()
        {
            return View(await db.Expedientes.ToListAsync());
        }

        // GET: Expediente/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expediente expediente = await db.Expedientes.FindAsync(id);
            if (expediente == null)
            {
                return HttpNotFound();
            }
            return View(expediente);
        }

        // GET: Expediente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expediente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,LGIdNumber,SospechaCovid,Sintomas,FechaConsulta,LugarConsulta,TestCovid,CuandoSeRealizoTest,DondeSeRealizo,Status,Incapacidad,FolioIncapacidad,FechaInicioIncapacidad,DiasIncapacidad,PacienteSelforOther,TelContacto,LastChangeDate,LastChangeUser")] Expediente expediente)
        {
            if (ModelState.IsValid)
            {
                db.Expedientes.Add(expediente);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(expediente);
        }

        // GET: Expediente/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expediente expediente = await db.Expedientes.FindAsync(id);
            if (expediente == null)
            {
                return HttpNotFound();
            }
            return View(expediente);
        }

        // POST: Expediente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,LGIdNumber,SospechaCovid,Sintomas,FechaConsulta,LugarConsulta,TestCovid,CuandoSeRealizoTest,DondeSeRealizo,Status,Incapacidad,FolioIncapacidad,FechaInicioIncapacidad,DiasIncapacidad,PacienteSelforOther,TelContacto,LastChangeDate,LastChangeUser")] Expediente expediente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expediente).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(expediente);
        }

        // GET: Expediente/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expediente expediente = await db.Expedientes.FindAsync(id);
            if (expediente == null)
            {
                return HttpNotFound();
            }
            return View(expediente);
        }

        // POST: Expediente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Expediente expediente = await db.Expedientes.FindAsync(id);
            db.Expedientes.Remove(expediente);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
