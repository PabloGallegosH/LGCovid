using LGCovid.Logic;
using LGCovid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LGCovid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Expediente()
        {
            ViewBag.Message = "My Expediente page.";
            return View();
        }


        [HttpPost]
        public ActionResult Expediente(Expediente expediente)
        {
            if (ModelState.IsValid)
            {
                ExpedientesLogic logic = new ExpedientesLogic();
                logic.AddExpediente(expediente);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

    }
}