using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InitialApp1.Controllers
{
    public class DemoController : Controller
    {
        
        public ActionResult Index()
        {
            return Content("This Is Content Result !");
        }
    }
}