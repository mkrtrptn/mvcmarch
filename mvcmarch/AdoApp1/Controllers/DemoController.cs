using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using AdoApp1.Models;

namespace AdoApp1.Controllers
{
    public class DemoController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult store(bank b)
        {
            try
            {
                SqlConnection con = new SqlConnection("user id=sa;password=123;database=REMOTE;data source=MUKTAR");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into bank values( @accno ,@accname,@bal )";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@accno", b.accno);
                cmd.Parameters.AddWithValue("@accname", b.accname);
                cmd.Parameters.AddWithValue("@bal", b.balance);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                ViewBag.info = "info Saved !";
            }
            catch(Exception)
            {
                ViewBag.info = "Error Occured !";
            }

            return View(b);
        }


    }
}