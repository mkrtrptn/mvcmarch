using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DataAnnotationValidationApp.Models
{
    public class UserModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage ="Enter Username !")]
        public string uname { set; get; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Enter Password !")]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage = "Enter Password Including One Num 0-9 , one lowercase , one uppercase , one symbol @#$% ,length 6-20  ")]
        public string password { set; get; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Comfirm password !")]
        [System.ComponentModel.DataAnnotations.Compare("password",ErrorMessage ="Password Doesn't match ")]
        public string cpassword { set; get; }


        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Enter Address !")]
        public string address { set; get; }


        [Range(18,38,ErrorMessage ="Age Between 18-38 only !")]
        [Required(ErrorMessage ="Enter Age !")]
        public string age { set; get; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Select Dob !")]
        public string dob { set; get; }


        [RegularExpression("[0-9]{10}",ErrorMessage ="Enter 10 Digit Mobile !")]
        [Required(ErrorMessage ="Enter Mobile Number !")]
        public long mobile { set; get; }

        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Enter Email Address")]
        public string email { set; get; }



        [Remote("passcode","Demo" ,ErrorMessage ="Enter Valid Pass Code " )]
        [Required(ErrorMessage ="Enter Passcode !")]
        public int passcode { set; get; }

    }
}