using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text;


namespace demo.MVC.Controllers
{
    public class TmdbApiController : Controller
    {
        public ActionResult index()
        {
            return View();
        }

        public ActionResult GetFavoriteMovies()
        {
            return View();
        }
      

        public ActionResult FindMovies() 
        {
            return View("FindMovies");
        }

        public ActionResult FindStars() 
        {
            return View("FindStars");
        }

        public ActionResult FindLatestMovies()
        {
            return View("FindLatestMovies");
        }

        public ActionResult FindMovieCredits()
        {
            return View("FindMovieCredits");
        }
    }
}