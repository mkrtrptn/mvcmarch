using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelApp.Models;


namespace ViewModelApp.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult Index()
        {
            StudentModel sobj = new StudentModel
            {
                studid = 101 , studname="Johan"
            };

            FacultyModel fobj = new FacultyModel
            {
                facultyid = 10, facultyname = "Kristen"
            };

            FSViewModel facultystudent = new FSViewModel
            {
                student= sobj, faculty = fobj 
            };



            return View(facultystudent);
        }
    }
}