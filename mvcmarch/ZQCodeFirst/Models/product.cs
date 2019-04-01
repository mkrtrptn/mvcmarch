using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZQCodeFirst.Models
{
    public class product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int prodid { get; set; }

        [Required(ErrorMessage ="Enter Product Name")]
        public string prodname { get; set; }

        [Required(ErrorMessage ="Enter Price")]
        public double price { get; set; }

        [Required(ErrorMessage ="Enter Quantity ")]
        public int quantity { get; set; }


    }
}