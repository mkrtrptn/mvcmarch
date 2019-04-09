using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingNormalAttributeBased.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {   
            return View();
        }

        public ActionResult productbyid(int pid)
        {
            ViewBag.res = "Product ID" + pid;
            return View();
        }

        public ActionResult productbyidname(int pid , string name)
        {
            ViewBag.res = "Product Id" + pid + "Product Name" + name;
            return View();
        }


    }
}