using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UntyedHelperControl.Models;

namespace UntyedHelperControl.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult store()
        {
            string amenities = "";

            if (Request.Form["c1"] != "false")
                amenities = "wifi";
            if (Request.Form["c1"] != "false")
                amenities = amenities + "AC";


            CustomerModel cobj = new CustomerModel
            {
                custname = Request.Form["txtname"],
                roomtype = Request.Form["room"],
                amenities = amenities 
                
            };



            return View(cobj);
        }

    }
}