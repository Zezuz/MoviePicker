using Microsoft.AspNetCore.Mvc;
using MoviePicker.Models;
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
        public IActionResult Index(string searchString)
        {
            var movies = repo.GetAllMovies();

            if (!String.IsNullOrEmpty(searchString)) 
            {
                movies = movies.Where(s => s.Name.Contains(searchString));
            }
            return View(movies);
        }

        public IActionResult ViewMovie(int id) 
        {
            var movie = repo.GetMovie(id);

            return View(movie);
        }

        public IActionResult ViewGenre(string Genre) 
        {
            var Genre2 = repo.GetAllGenre(Genre);

            return View(Genre2);
        }

        
    }
}
