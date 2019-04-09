using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace EagerLazyLoadingAndMetadata.Models
{
    public class ProductVal
    {
        
        public int prodid { get; set; }
        [Required(ErrorMessage ="Enter Product Description")]
        public string proddesc { get; set; }
        [Required(ErrorMessage ="Enter Price")]
        [Range(10000,900000,ErrorMessage ="Range 10000 - 90000")]
        public decimal? prodprice { get; set; }
        [Required(ErrorMessage ="Select Category")]
        public int? cateid { get; set; }

        public virtual category category { get; set; }
    }
}