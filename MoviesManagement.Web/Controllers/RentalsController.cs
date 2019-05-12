using System.Collections.Generic;
using System.Web.Mvc;
using MoviesManagement.Management.Controllers;
using MoviesManagement.Web.Models;

namespace MoviesManagement.Web.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save()
        {

            return View();
        }

        public ActionResult GetCustomers(string query)
        {
            List<Autocomplete> people = new List<Autocomplete>();

            var customerManagement = new CustomerManagement();
            var customers = customerManagement.GetCustomersWithQuery(query);

            foreach (var customerDto in customers)
            {
                var person = new Autocomplete
                {
                    Id = customerDto.Id,
                    Name = customerDto.Name
                };
                people.Add(person);
            }

            return Json(people, JsonRequestBehavior.AllowGet);
        }
    }
}