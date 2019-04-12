using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Models;
using System.Web.Http.Cors;

namespace WebApiServer.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*" )]
    public class InventoryController : ApiController
    {
        InventoryEntities obj = new InventoryEntities();

        public List<product> getproducts()
        {
            return obj.products.ToList();
        }

        public product getproduct(int id)
        {
            var pro = obj.products.Find(id);
            return pro;
        }

        public string postproduct(product p)
        {
            try
            {
                obj.products.Add(p);
                obj.SaveChanges();
                return "added";
            }
            catch(Exception)
            {
                return "duplicate";
            }
        }


        public void putproduct(product p)
        {
            var pro =  obj.products.Find(p.prodid);
            pro.proddesc = p.proddesc;
            pro.prodprice = p.prodprice;
            pro.cateid = p.cateid;
            obj.SaveChanges();
        }

        public void deleteproduct(int id)
        {
            var pro =  obj.products.Find(id);
            obj.products.Remove(pro);
            obj.SaveChanges();
        }



    }
}
