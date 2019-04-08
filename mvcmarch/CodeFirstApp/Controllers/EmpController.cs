using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApp.Models;


namespace CodeFirstApp.Controllers
{
    public class EmpController : Controller
    {
        mycontext obj = new mycontext();
        
        public ActionResult addemp()
        {
            List<SelectListItem> dlist = new List<SelectListItem>();
            foreach(var i in obj.department.ToList())
            {
                dlist.Add(new SelectListItem { Text = i.dname, Value = i.did.ToString() });
            }
            ViewBag.dept = dlist;
            
            return View();
        }

        [HttpPost]
        public ActionResult addemp(employee e)
        {
            obj.employees.Add(e);
            obj.SaveChanges();
            //return View("~/Views/Demo/Index.cshtml");
            return RedirectToAction("displayemp","Emp");
        }

        public ActionResult displayemp()
        {
            var res = from d in obj.department join e in obj.employees on d.did equals e.did select new EmpDept { eid = e.eid , ename = e.ename, email = e.email , address = e.address , mobile = e.mobile , dname = d.dname  };

            return View(res);
        }

        public ActionResult editemp(int id)
        {
            List<SelectListItem> dlist = new List<SelectListItem>();
            foreach(var d in obj.department.ToList())
            {
                dlist.Add(new SelectListItem { Text=d.dname , Value = d.did.ToString()});
            }
            ViewBag.dep = dlist;

            employee e = obj.employees.Find(id);
            return View(e);
        }

        [HttpPost]
        public ActionResult editemp(employee e)
        {
            employee emp = obj.employees.Find(e.eid);
            emp.ename = e.ename;
            emp.email = e.email;
            emp.did = e.did;
            emp.address = e.address;
            emp.mobile = e.mobile;
            obj.SaveChanges();
            return RedirectToAction("displayemp" , "Emp");
        }

        public ActionResult deleteemp(int id)
        {
            employee emp = obj.employees.Find(id);
            obj.employees.Remove(emp);
            obj.SaveChanges();
            return RedirectToAction("displayemp" ,"Emp" );
        }




    }
}
