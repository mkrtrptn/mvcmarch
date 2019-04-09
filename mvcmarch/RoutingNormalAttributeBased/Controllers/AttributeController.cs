using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingNormalAttributeBased.Controllers
{
    [RoutePrefix("test")]
    public class AttributeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [Route("pbid/{pid}")]
        public ActionResult productbyid(int pid)
        {
            ViewBag.res = "Product ID" + pid;
            return View();
        }

        [Route("pbidname/{pid}/{name}")]
        public ActionResult productbyidname(int pid,string name)
        {
            ViewBag.res = "Product Id" + pid + "Product Name" + name;
            return View();
        }


    }
}