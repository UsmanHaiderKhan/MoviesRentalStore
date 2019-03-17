using MoviesRentalStore.Models;
using System.Linq;
using System.Web.Mvc;

namespace MoviesRentalStore.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationContext _context;

        public CustomersController()
        {
            _context = new ApplicationContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }

        public ActionResult CustomerDetails(int id)
        {
            return View();
        }
    }
}
