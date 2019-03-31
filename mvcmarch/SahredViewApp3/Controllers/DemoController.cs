using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SahredViewApp3.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult errorDemo()
        {
            ViewBag.msg = "From Demo Controller !";
            return View("error");
        }
        public ActionResult months()
        {
            List<string> obj = new List<string> { "Jan" , "Feb" , "March" , "April","May","June","July"};

            ViewBag.obj = obj;
            return View("common");
        }
    }
}