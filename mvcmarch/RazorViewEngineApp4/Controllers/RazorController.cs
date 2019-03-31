using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorViewEngineApp4.Controllers
{
    public class RazorController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
    }
}