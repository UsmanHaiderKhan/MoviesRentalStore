using MoviesRentalStore.Models;
using System;
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
            return RedirectToAction("index", "Home", new { Page = 1, sortby = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("ID=" + id);
        }

        public ActionResult Index(int? pageindex, string sortBy)
        {
            if (!pageindex.HasValue)


                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))

                sortBy = "Name";
            return Content(String.Format("pageindex={0}&sortby{1}", pageindex, sortBy));

        }
    }
}
