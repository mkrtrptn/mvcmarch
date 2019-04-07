using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoCrudApp.Models;
using System.Data.SqlClient;


namespace AdoCrudApp.Controllers
{
    public class DemoController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult store(bankapp c)
        {
            if(ModelState.IsValid)
            { 
            SqlConnection con = new SqlConnection("user id=sa;password=123;database=REMOTE;data source=MUKTAR");
            SqlCommand cmd = new SqlCommand("insert into bankapp values(@accno , @accname,@balance)",con);

            cmd.Parameters.AddWithValue("@accno",c.accno);
            cmd.Parameters.AddWithValue("@accname", c.accname);
            cmd.Parameters.AddWithValue("@balance",c.balance);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            return View("Index");
            }
            return View("Index");
        }


        public PartialViewResult record()
        {
            List<bankapp> obj = new List<bankapp>();

            SqlConnection con = new SqlConnection("user id=sa;password=123;database=REMOTE;data source=MUKTAR");
            SqlCommand cmd = new SqlCommand("select * from bankapp",con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                obj.Add(new bankapp { accno = (long)dr["accno"], accname= dr["accname"].ToString(), balance = Convert.ToDouble(dr["balance"]) } );
            }

            dr.Close();
            con.Close();
            
            return PartialView(obj);
        }


        public PartialViewResult add()
        {
            return PartialView();
        }





        public ActionResult manip(bankapp c , string op)
        {
            SqlConnection con = new SqlConnection("user id=sa;password=123;data source=Muktar;database=REMOTE");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            switch(op)
            {
                case "search":
                    cmd.CommandText = "select * from bankapp where accno=@accno";
                    cmd.Parameters.AddWithValue("@accno",c.accno);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        ViewBag.accno = dr["accno"];
                        ViewBag.accname = dr["accname"];
                        ViewBag.balance = dr["balance"];
                    }
                    dr.Close();
                    con.Close();

                    break;

                case "delete":
                    cmd.CommandText = "delete from bankapp where accno = @accno";
                    cmd.Parameters.AddWithValue("@accno",c.accno);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    break;

                case "update":
                    cmd.CommandText = "update bankapp  set accno=@accno , accname=@accname, balance=@balance where accno = @accno";
                    cmd.Parameters.AddWithValue("@accno",c.accno);
                    cmd.Parameters.AddWithValue("@newaccno",c.accno);
                    cmd.Parameters.AddWithValue("@accname",c.accname);
                    cmd.Parameters.AddWithValue("@balance",c.balance);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    break;
                    
            }


            return View("Index");
        }








    }
}