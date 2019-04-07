using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirstApp.Models
{
    public class employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int eid { set; get; }

        public string ename { set; get; }

        public string email { set; get; }
        
        public string  address { set; get; }

        public string mobile { set; get; }

        public int did { set; get; }

        [ForeignKey("did")]
        public dept depno { set; get; }



    }
}