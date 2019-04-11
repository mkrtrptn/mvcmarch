using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxCascadings.Models;


namespace AjaxCascadings.Controllers
{
    public class DemoController : Controller
    {
        ProductEntities obj = new ProductEntities();
      
        public ActionResult Index()
        {
            List<SelectListItem> cat = new List<SelectListItem>();
            cat.Add(new SelectListItem { Text="-Select Category-"});
 
            foreach(var i in obj.categories.ToList())
            {
                cat.Add(new SelectListItem { Text=i.catedesc , Value=i.cateid.ToString() });
            }

            ViewBag.cat = cat;

            return View();
        }

        public JsonResult getprod(int id)
        {
            var pro = from p in obj.products where p.cateid == id select new { p.proddesc , p.prodid};
            return Json(pro,JsonRequestBehavior.AllowGet);
        }


        


    }
}