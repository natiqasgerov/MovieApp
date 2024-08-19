using MovieApp.Models;
using System.Collections.Generic;

namespace MovieApp.ViewModels
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
