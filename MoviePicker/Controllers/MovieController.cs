using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePicker.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepo repo;

        public MovieController(IMovieRepo repo) 
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var movies = repo.GetAllMovies();
            return View(movies);
        }

        public IActionResult ViewMovie(int movieID) 
        {
            var movie = repo.GetMovie(movieID);

            return View(movie);
        }

        public IActionResult ViewGenre(string Genre) 
        {
            var Genre2 = repo.GetAllGenre(Genre);

            return View(Genre2);
        }
    }
}
