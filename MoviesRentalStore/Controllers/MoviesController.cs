using MoviesRentalStore.Models;
using System.Web.Mvc;

namespace MoviesRentalStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            var movies = new Movie()
            {
                Name = "Dome4",

            };
            return View(movies);
        }
    }
}
