using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Model.Movie movie = new Model.Movie
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            ViewData["name"] = movie.Title;
            return View(movie);
        }
    }
}