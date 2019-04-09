using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace AjaxReadXmlFileDemo.Controllers
{
    public class DemoController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public string getnews()
        {
            var res = XElement.Load(Server.MapPath("/files/news.xml"));
            string info = res.Element("msg").Value;

            return info;
        }

    }
}