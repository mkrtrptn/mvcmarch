using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsApp2.Controllers
{
    public class DemoController : Controller
    {
       // Views Demo Application
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }


    }
}