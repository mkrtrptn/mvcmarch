using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZQCodeFirst.Models;
using System.Data.Entity;
using System.Net;

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

        public ActionResult editproduct(int id)
        {
            var prod = obj.products.Find(id);
            return View(prod);
        }

        [HttpPost]
        public ActionResult editproduct(product p)
        {
            product pro = obj.products.Find(p.prodid);
            pro.prodname = p.prodname;
            pro.price = p.price;
            pro.quantity = p.quantity;
           
            //obj.Entry(pro).State = EntityState.Modified;
            obj.SaveChanges();
           
            return View("Index");
        }



        public ActionResult deleteproduct(int? id)
        {
            if(id !=null)
            {
                product pro = obj.products.Find(id);
                return View(pro);

            }
            else
            {
                return View("Index");
            }
        }


        [HttpPost]
        public ActionResult deleteproduct(product p)
        {
             if( p !=null)
            {
                product pro = obj.products.Find(p.prodid);
                obj.products.Remove(pro);
                obj.SaveChanges();
                return View("Index");
            }
             else
            {
                return View("Index");
            }

        }



    }
}