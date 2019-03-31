using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlControllsApp7.Controllers
{
    public class HtmlDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult submit(FormCollection f)
        {
            TempData["name"] = f["txtname"];
            TempData["password"] = f["txtpass"];
            TempData["tech"] = f["listbox"];
            TempData["education"] = f["dropdown"];
            TempData["address"] = f["textarea"];
            TempData["passed"] = f["status"];
            TempData["gender"] = f["gender"];
            TempData["weight"] = f["weight"];
            TempData["dob"] = f["dob"];
            TempData["email"] = f["email"];
          
            return RedirectToAction("welcome");
        }

        public ActionResult welcome()
        {
            return View();
        }

        public ActionResult close()
        {
            return View();
        }


    }
}