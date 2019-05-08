using System.Web.Mvc;
using MoviesManagement.Management.Controllers;

namespace MoviesManagement.Web.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customerManagement = new CustomerManagement();
            return View(customerManagement.GetCustomers());
        }
    }
}