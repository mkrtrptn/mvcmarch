using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SahredViewApp3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult errorHome()
        {
            ViewBag.msg = "From Home Controller !";
            return View("error");
        }

        public ActionResult days()
        {
            List<string> obj = new List<string>();
            obj.Add("Sunday");
            obj.Add("Monday");
            obj.Add("Tuesday");
            obj.Add("Wednsday");
            obj.Add("Thursday");
            obj.Add("Friday");
            obj.Add("Saturday");

            ViewBag.obj = obj;

            return View("common");
        }



    }
}