using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using MovieApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult List(string id,string query)
        {
            var moviesList = new List<Movie>();

            if (string.IsNullOrWhiteSpace(id))
                moviesList = MovieRepository.GetMovies();
            else
                moviesList = MovieRepository.GetMovies().Where(x => x.GenreId == id).ToList();

            if(!string.IsNullOrWhiteSpace(query))
                moviesList = moviesList.Where(x => x.Title.ToLower().Contains(query.ToLower())).ToList();

            var viewModel = new MovieGenreViewModel
            {
                Movies = moviesList
            };

            return View(viewModel);
        }

        public IActionResult Details(string id)
        {
            return View(MovieRepository.GetByIdMovie(id));
        }
    }
}
