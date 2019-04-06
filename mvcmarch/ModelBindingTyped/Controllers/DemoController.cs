using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingTyped.Models;
namespace ModelBindingTyped.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> obj = new List<SelectListItem>();
            obj.Add(new SelectListItem{ Text ="India" , Value = "India"});
            obj.Add(new SelectListItem { Text="US" , Value="US"});
            obj.Add(new SelectListItem { Text="Australia" , Value="Australia"});

            ViewBag.country = obj;

            List<string> obj2 = new List<string>();
            obj2.Add("Angular");
            obj2.Add("DOT NET CORE");
            obj2.Add("Microservices");
            obj2.Add("Azure");

            ViewBag.skills = obj2;

            return View();
        }

        public ActionResult store(Candidate obj)
        {
            obj.skills = Request.Form["skills"];

            return View(obj);
        }


    }
}