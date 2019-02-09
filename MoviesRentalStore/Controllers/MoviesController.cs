using MoviesRentalStore.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MoviesRentalStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        [Route("Movies/RelaseByDate/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult RelaseByDate(int year, int month)
        {
            return Content($"Year:{year} && Month{month}");
        }

        public ActionResult Random()
        {
            var movies = new Movie()
            {
                Name = "Dome4",

            };
            var customer = new List<Customer>
            {
                new Customer {Name = "Usman Haider Khan", Id = 1},
                new Customer {Name = "Salman Khan", Id = 2}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Customer = customer,
                Movie = movies
            };
            return View(viewModel);
            //return RedirectToAction("index", "Home", new { Page = 1, sortby = "name" });
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
