using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviePicker.Models;
using System.Data;
using Dapper;

namespace MoviePicker
{
    public class MovieRepo : IMovieRepo
    {
        private readonly IDbConnection _conn;
        

        public MovieRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Movies> GetAllMovies() 
        {
            return _conn.Query<Movies>("SELECT * FROM MOVIES");
        }

        public Movies GetMovie(int id)
        {
            
            return _conn.QuerySingle<Movies>("SELECT * FROM MOVIES WHERE MOVIEID = @id", new { id = id });
        }

        public IEnumerable<Movies> GetGenre(string Genre)
        {
            return _conn.Query<Movies>("Select * From Movies where Genre = @Genre", new { genre = Genre });
        }

       
    }
}
