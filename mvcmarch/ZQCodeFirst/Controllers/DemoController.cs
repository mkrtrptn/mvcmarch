using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZQCodeFirst.Models;

namespace ZQCodeFirst.Controllers
{
    public class DemoController : Controller
    {
        ProductDbContext obj = new ProductDbContext();
       
       
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult prods()
        {
            var prodlist = obj.products.ToList();
            return PartialView(prodlist);
        }

        public ActionResult addproduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addproduct(product p)
        {
            obj.products.Add(p);
            obj.SaveChanges();
            return View("Index");
        }


    }
}