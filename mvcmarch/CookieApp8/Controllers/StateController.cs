using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieApp8.Controllers
{
    public class StateController : Controller
    {
        
        public ActionResult Index()
        {
            if(Request.Cookies["val"] == null)
            {
                ViewBag.msg = "This Is Your First Visit Welcome";
                Response.Cookies["val"].Value = DateTime.Now.ToString();
                Response.Cookies["val"].Expires = DateTime.Now.AddMinutes(5);

            }
            else
            {
                ViewBag.msg = "Your Last Visit" + Request.Cookies["val"].Value;
                Response.Cookies["val"].Value = DateTime.Now.ToString();
                Response.Cookies["val"].Expires = DateTime.Now.AddMinutes(5);

            }
           
            return View();
        }
    }
}