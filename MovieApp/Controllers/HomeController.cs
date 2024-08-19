using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var popularMovie = MovieRepository.GetByIdMovie("22");

            return View(popularMovie);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
