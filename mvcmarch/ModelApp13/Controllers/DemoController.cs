using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelApp13.Models;

namespace ModelApp13.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            CustomerModel obj = new CustomerModel();
            obj.custid = 101;
            obj.custname = "Rahul";
            ViewBag.customer = obj;


            return View();
        }

        public ActionResult store()
        {
            CustomerModel obj = new CustomerModel
            {
                custid = 102, custname = "Ritesh" 
            };
            return View(obj);
        }

    }
}