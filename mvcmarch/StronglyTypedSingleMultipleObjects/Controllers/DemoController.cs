using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedSingleMultipleObjects.Models;


namespace StronglyTypedSingleMultipleObjects.Controllers
{
    public class DemoController : Controller
    {
        
        public ActionResult Index()
        {
            StudentModel obj = new StudentModel
            {
                sid = 101 , sname = "Andrew" , spic ="user1.png"
            };
            
            return View(obj);
        }


        public ActionResult students()
        {

            List<StudentModel> obj = new List<StudentModel>();

            obj.Add(new StudentModel { sid=101, sname = "Andrew" , spic ="user1.png"});
            obj.Add(new StudentModel { sid=102, sname="Johan" , spic="user2.jpg"});
            obj.Add(new StudentModel { sid=103, sname="Mahendra" , spic="user3.png"});
            obj.Add(new StudentModel { sid=104, sname="Ravindra" , spic="user4.png"});
            obj.Add(new StudentModel { sid=105, sname="Suresh" , spic="user5.png"});
            obj.Add(new StudentModel { sid=106 , sname="Shane Watson" , spic="user7.jpg"});
            obj.Add(new StudentModel { sid = 107 , sname="Emma" , spic="user6.jpg"});


            return View(obj);
        }



    }
}