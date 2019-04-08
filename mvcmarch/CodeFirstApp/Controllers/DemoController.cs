using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApp.Models;


namespace CodeFirstApp.Controllers
{
    public class DemoController : Controller
    {
        mycontext obj = new mycontext();

       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult adddept()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adddept(dept d)
        {
            obj.department.Add(d);
            obj.SaveChanges();
            return View("Index");

        }

        public ActionResult displaydept()
        {
            return View(obj.department.ToList());
        }
        
        public ActionResult editdept(int id)
        {
            dept dep =  obj.department.Find(id);
            return View(dep);
        }

        [HttpPost]
        public ActionResult editdept(dept d)
        {
            dept dep = obj.department.Find(d.did);
            dep.dname = d.dname;
            obj.SaveChanges();

            return View("displaydept",obj.department.ToList());
        }

        public ActionResult deletedept(int id)
        {
            dept dep = obj.department.Find(id);
            obj.department.Remove(dep);
            obj.SaveChanges();

            return View("displaydept",obj.department.ToList());
        }




    }
}