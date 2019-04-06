using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelbindingUntyped.Models;
namespace ModelbindingUntyped.Controllers
{
    public class DemoController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult store(UserModel u)
        {
            return View(u);
        }


    }


}