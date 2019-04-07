using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoMovieGalleryApp.Models;

namespace AdoMovieGalleryApp.Controllers
{
    public class MovieController : Controller
    {
        DAL obj = new DAL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult add()
        {
            return View();
        }


        public ActionResult store(movie m)
        {
            HttpPostedFileBase file = Request.Files["m1"];

            m.moviefile = m.movieid + ".mp4";
            string path = Server.MapPath("/videos/") + m.moviefile;
            file.SaveAs(path);
            obj.addmovie(m);

            return RedirectToAction("display");
        }


        public ActionResult display()
        {
            List<movie> movies = new List<movie>();
            movies = obj.getmovies();
            return View(movies);
        }


        public ActionResult delete(int id)
        {
            string path = Server.MapPath("/videos/") + id + ".mp4";
            System.IO.File.Delete(path);
            obj.deletemovie(id);
            return View("Index");
        }



    }
}