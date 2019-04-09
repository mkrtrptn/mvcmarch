using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbFirstApp.Models;


namespace DbFirstApp.Controllers
{
    public class InventoryController : Controller
    {
        Inventory obj = new Inventory();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult addproduct()
        {
            List<SelectListItem> lst = new List<SelectListItem>();

            foreach(var i in obj.categories.ToList())
            {
                lst.Add(new SelectListItem { Text = i.catedesc , Value=i.cateid.ToString() });
            }
            ViewBag.cat = lst;

            return PartialView();
        }

        [HttpPost]
        public ActionResult addproduct(product p )
        {
            if(ModelState.IsValid)
            {
                obj.addp(p.proddesc, p.prodprice, p.cateid);
                obj.SaveChanges();
                return View("Index");
            }
            else
            return View("Index");
        }

        public PartialViewResult displayproduct()
        {
            return PartialView(obj.products.ToList());
        }






    }
}