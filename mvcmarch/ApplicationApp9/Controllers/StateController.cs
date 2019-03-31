using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationApp9.Controllers
{
    public class StateController : Controller
    {
        public ActionResult Index()
        {
           return View();
        }

        public ActionResult store()
        {
            HttpContext.Application["comments"] = "<span>"  + HttpContext.Application["comments"].ToString() + Request.Form["cmt"] +"</span>"+ "<br/>";

            return View("Index");
        }
    }
}