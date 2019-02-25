using Microsoft.VisualStudio.TestTools.UnitTesting;
using demo.MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace demo.MVC.Controllers.Tests
{
    [TestClass()]
    public class TmdbApiControllerTests
    {
        //----- test latest movies action returns the correct view
        [TestMethod()]
        public void FindLatestMoviesTest()
        {
            var controller = new TmdbApiController();
            var result = controller.FindLatestMovies() as ViewResult;
            Assert.AreEqual("FindLatestMovies", result.ViewName);

        }

        //------- Test Find Movies-------
        [TestMethod()]
        public void FindMovies()
        {
            var controller = new TmdbApiController();
            var result = controller.FindMovies() as ViewResult;
            Assert.AreEqual("FindMovies", result.ViewName);
        }

        //------- Test Find stars-------
        [TestMethod()]
        public void FindStars()
        {
            var controller = new TmdbApiController();
            var result = controller.FindStars() as ViewResult;
            Assert.AreEqual("FindStars", result.ViewName);
        }

        //------- Test Find similar movies-------
        [TestMethod()]
        public void FindSimilarMovies()
        {
            var controller = new TmdbApiController();
            var result = controller.FindSimilarMovies() as ViewResult;
            Assert.AreEqual("FindSimilarMovies", result.ViewName);
        }

        //------- Test Find Movies credits-------
        [TestMethod()]
        public void FindMovieCredits()
        {
            var controller = new TmdbApiController();
            var result = controller.FindMovieCredits() as ViewResult;
            Assert.AreEqual("FindMovieCredits", result.ViewName);
        }



    }
}