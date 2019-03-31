using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultTypes.Controllers
{
    public class ResultsController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult viewdemo()
        {
            return View();
        }

        public ContentResult contentdemo()
        {
            return Content("This Is Content Demo !");
        }

        public RedirectToRouteResult routedemo()
        {
           return RedirectToAction("Index","Results");
        }

        public FileResult filedemo()
        {
            return File("~/Images/25.jpg","Image/jpg","nature.jpg");
        }

        public PartialViewResult partialviewdemo()
        {
            return PartialView();
        }

        public RedirectResult redirectdemo()
        {
            return Redirect("www.google.com");
        }

    }
}