using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ZQDbFirst.Models;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace ZQDbFirst.Controllers
{
    public class DemoController : Controller
    {
        Productdb obj = new Productdb();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult prods()
        {
            return PartialView(obj.productrecords.ToList());
        }

        public ActionResult addproduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addproduct(productrecord p)
        {
            if (ModelState.IsValid)
            {
                obj.productrecords.Add(p);
                obj.SaveChanges();
                return View("Index");
            }
            else
            {
                return View();

            }
        }


        public ActionResult editproduct(int? id)
        {
            productrecord pro = obj.productrecords.Find(id);
            return View(pro);
        }


        [HttpPost]
        public ActionResult editproduct(productrecord p)
        {
            if (p != null)
            {
                var pro = obj.productrecords.Find(p.pid);
                pro.pname = p.pname;
                pro.price = p.price;
                pro.quantity = p.quantity;
                obj.SaveChanges();
                return View("Index");
            }
            else
            {
                return View("Index");
            }

        }


        public ActionResult deleteproduct(int? id)
        {
            if (id != null)
            {
                productrecord pro = obj.productrecords.Find(id);
                return View(pro);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        [ActionName("deleteproduct")]
        public ActionResult delete(int? id)
        {
            if(id != null)
            {
                var pro = obj.productrecords.Find(id);
                obj.productrecords.Remove(pro);
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