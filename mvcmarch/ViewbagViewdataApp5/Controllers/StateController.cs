using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewbagViewdataApp5.Controllers
{
    public class StateController : Controller
    {
       
        public ActionResult Index()
        {
            List<string> technologies = new List<string> { "Angular","C#","MVC","Web API","JQuery","SQl Server","Ajax"};
            ViewBag.tech = technologies;

            ViewBag.result = 100;

            


            List<string> additions = new List<string> { ".Net Core" , "Microservices" , "Swagger" ,"React" };
            ViewData["newtech"] = additions;

            ViewData["value"] = 900;


            return View();
        }
    }
}