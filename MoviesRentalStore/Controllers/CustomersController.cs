using System.Web.Mvc;

namespace MoviesRentalStore.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerDetails(int id)
        {
            return View();
        }
    }
}
