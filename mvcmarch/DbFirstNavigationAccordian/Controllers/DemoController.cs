using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbFirstNavigationAccordian.Models;
namespace DbFirstNavigationAccordian.Controllers
{
    public class DemoController : Controller
    {
        REMOTEEntities obj = new REMOTEEntities();

        public ActionResult Index()
        {
            return View(obj.categories.ToList());
        }
    }
}