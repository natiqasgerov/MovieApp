using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieApp.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var genreList = GenreRepository.GetGenres();

            return View(genreList);
        }
    }
}
