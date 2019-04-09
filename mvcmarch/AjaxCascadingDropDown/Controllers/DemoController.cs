using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxCascadingDropDown.Models;

namespace AjaxCascadingDropDown.Controllers
{
    public class DemoController : Controller
    {
        ProductContext obj = new ProductContext();
        
        public ActionResult Index()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            lst.Add(new SelectListItem { Text= "-Select categorry-"});
            foreach(var c in obj.categories.ToList())
            {
                lst.Add(new SelectListItem { Text= c.catedesc , Value=c.cateid.ToString() });
            }
            ViewBag.cat = lst;
            
            return View();
        }

        public JsonResult getproducts(int catid)
        {
            var prod = from p in obj.products where p.cateid == catid select new {p.prodid , p.proddesc }; 

            return Json(prod , JsonRequestBehavior.AllowGet); 
        }


    }
}