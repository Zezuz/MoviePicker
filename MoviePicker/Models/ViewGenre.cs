using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePicker.Models
{
    public class ViewGenre
    {
        public List<Movies> Movies { get; set; }
        public SelectList genres { get; set; }
        public string Genre { get; set; }
        public string SearchString { get; set; }

    }
}
