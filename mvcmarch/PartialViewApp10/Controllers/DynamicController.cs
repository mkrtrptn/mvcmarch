using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewApp10.Controllers
{
    public class DynamicController : Controller
    {
      

        public PartialViewResult dynamicheader()
        {
            List<string> obj = new List<string>();
            obj.Add("Index");
            obj.Add("services");
            obj.Add("contact");
            obj.Add("about");

            ViewBag.action = obj; 
            
            return PartialView("_DynamicHeader");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult services()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }



    }
}