using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAnnotationValidationApp.Models;

namespace DataAnnotationValidationApp.Controllers
{
    public class DemoController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult store(UserModel u)
        {
            if(ModelState.IsValid )
            {
                return View(u);
            }
            else
            {
                return View("Index");
            }
        }

        public JsonResult passcode(int passcode)
        {
            bool flag;

            if (passcode == 112233)
                flag = true;
            else
                flag = false;

            return Json(flag,JsonRequestBehavior.AllowGet);


        }


    }
}