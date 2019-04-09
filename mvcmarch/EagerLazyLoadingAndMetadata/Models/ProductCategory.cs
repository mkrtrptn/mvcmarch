using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EagerLazyLoadingAndMetadata.Models
{
    public class ProductCategory
    {
        public int prodid { set; get; }
        public string prodesc { set; get; }
        public decimal? prodprice { set; get; }

        public string catedec { set; get; }
        public int cateid { set; get; }
    }
}