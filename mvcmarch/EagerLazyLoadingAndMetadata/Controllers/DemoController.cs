using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EagerLazyLoadingAndMetadata.Models;


namespace EagerLazyLoadingAndMetadata.Controllers
{
    public class DemoController : Controller
    {
        ProductContext obj = new ProductContext();

        public ActionResult Index()
        {
            obj.Configuration.LazyLoadingEnabled = false;
            return View();
        }
        public ActionResult index2()
        {
            var filter = from p in obj.products join c in obj.categories on p.cateid equals c.cateid where p.prodprice > 10000 select new ProductCategory { prodid = p.prodid , prodesc = p.proddesc , prodprice = p.prodprice , catedec = c.catedesc , cateid = c.cateid   };
                          
            return View(filter);
        }


    }
}