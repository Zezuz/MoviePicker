using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePicker.Models
{
    public class Movies
    {
        public int movieid { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }
    }
}
