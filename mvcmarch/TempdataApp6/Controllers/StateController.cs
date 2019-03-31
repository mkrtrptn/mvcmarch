using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempdataApp6.Controllers
{
    public class StateController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult store()
        {
            TempData["value"] = 1000;
            return View("Index");
        }

        public ActionResult usepeek()
        {
            return View();
        }

        public ActionResult readandkeep()
        {
            return View();
        }

        public ActionResult normalread()
        {
            return View();
        }









    }
}