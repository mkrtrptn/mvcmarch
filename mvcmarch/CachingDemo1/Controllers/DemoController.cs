using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CachingDemo1.Models;

namespace CachingDemo1.Controllers
{
    public class DemoController : Controller
    {
        InventoryEntities db = new InventoryEntities();

        [OutputCache(Duration =180,Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult Index()
        {
            return View(db.products.ToList());

       
        }
    }
}