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

        [HttpPost]
        public string Index(string searchString, bool notUsed) 
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }
        public IActionResult Index(string searchString, string genre)
        {
            
            var movies = repo.GetAllMovies();

            if (!String.IsNullOrEmpty(searchString)) 
            {
                movies = movies.Where(s => s.Name.Contains(searchString));
                
            }
            if (!String.IsNullOrEmpty(genre)) 
            {
                movies = movies.Where(x => x.Genre.Contains(genre));
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
            var Genre2 = repo.GetGenre(Genre);

            return View(Genre2);
        }

        

        
    }
}
