using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyTesting.Models;
using VidlyTesting.ViewModels;

namespace VidlyTesting.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var moviesList = new List<Movie>
            {
                new Movie{ Id = 1, Name = "Shrek"},
                new Movie{ Id = 2, Name = "Wall-E"}
            };

            var viewModel = new CustomerViewModels
            {
                Movies = moviesList
            };

            return View(viewModel);
        }

        public ActionResult Details(int Id)
        {
            return View();
        }
    }
}