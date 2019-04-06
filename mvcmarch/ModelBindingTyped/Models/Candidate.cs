using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelBindingTyped.Models;
using System.ComponentModel.DataAnnotations;


namespace ModelBindingTyped.Models
{
    public class Candidate
    {
        public string name { set; get; }
        public string password { set; get; }
        public string gender { set; get; }
        public string country { set; get; }

        [DataType(DataType.EmailAddress)]
        public string email { set; get; }

        public string skills { set; get; }

        [DataType(DataType.Date)]
        public string  dob { set; get; }

        [DataType(DataType.PhoneNumber)]
        public string mobile { set; get; }
    }
}