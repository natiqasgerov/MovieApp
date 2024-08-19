using MovieApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Data
{
    public class GenreRepository
    {
        public static readonly List<Genre> _genres = null;
        static GenreRepository()
        {
            _genres = new List<Genre>()
            {
                 new Genre{GenreId = "1", Name = "Comedy"},
               new Genre{GenreId = "2", Name = "Action"},
               new Genre{GenreId = "3", Name = "National"},
               new Genre{GenreId = "4", Name = "Sport"}
            };
        }

        public static List<Genre> GetGenres() => _genres;

        public static void Add(Genre genre) => _genres.Add(genre);

        public static Genre GetByIdGenre(string id) => _genres.FirstOrDefault(x => x.GenreId == id);
    }
}
