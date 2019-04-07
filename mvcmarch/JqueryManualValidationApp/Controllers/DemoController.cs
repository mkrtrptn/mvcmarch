using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JqueryManualValidationApp.Models;

namespace JqueryManualValidationApp.Controllers
{
    public class DemoController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult store(user u)
        {
            return View(u);
        }
    }
}