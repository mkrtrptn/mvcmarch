using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActionOverloading.Models;
namespace ActionOverloading.Controllers
{
    public class DemoController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(arithmatic p , string operation)
        {
            if(operation == "add")
            {
                p.res = p.a + p.b; 
            }
            else if(operation =="sub")
            {
                p.res = p.a - p.b;
            }


            return View(p);
        }
    }
}