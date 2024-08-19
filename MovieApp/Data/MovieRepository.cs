using MovieApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace MovieApp.Data
{
    public class MovieRepository
    {
        public static readonly List<Movie> _movies = null;
        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie{ MovieId = "22",Title = "First",Description = "FirstDes",Director = " FirstDir",Actors = new []{"aa","bb"},ImageUrl = "1.jpg",GenreId = "2"},
                new Movie{ MovieId = "23", Title = "Second",Description = "SecondDes",Director = " SecondDir",Actors = new []{"aa","bb"},ImageUrl = "2.jpg",GenreId = "1"},
                new Movie{ MovieId = "24", Title = "Third",Description = "ThirdDes",Director = " ThirdDir",Actors = new []{"aa","bb"},ImageUrl = "3.jpg", GenreId = "3"}
            };
        }

        public static List<Movie> GetMovies() => _movies;

        public static void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetByIdMovie(string id) => _movies.FirstOrDefault(x => x.MovieId == id);
    }
}
