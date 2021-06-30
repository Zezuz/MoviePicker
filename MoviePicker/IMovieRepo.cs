using MoviePicker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePicker
{
    public interface IMovieRepo 
    {
        public IEnumerable<Movies> GetAllMovies();

        public Movies GetMovie(int id);

        public IEnumerable<Movies> GetAllGenre(string Genre);
    }

    
}
