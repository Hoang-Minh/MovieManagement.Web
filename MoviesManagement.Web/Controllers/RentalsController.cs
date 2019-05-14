using System.Collections.Generic;
using System.Web.Mvc;
using MoviesManagement.DataContract;
using MoviesManagement.Management.Controllers;

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
            var people = new List<Autocomplete>();

            var customerManagement = new CustomerManagement();
            var customers = customerManagement.GetCustomersWithQuery(query);

            foreach (var customerDto in customers)
            {
                var person = new Autocomplete
                {
                    Id = customerDto.Id,
                    Name = customerDto.Name,
                    BirthDate = customerDto.Birthdate
                };
                people.Add(person);
            }

            return Json(people, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetMovies(string query)
        {
            var movies = new List<Autocomplete>();

            var movieManagement = new MovieManagement();
            var customers = movieManagement.GetMoviesWithQuery(query);

            foreach (var customerDto in customers)
            {
                var movie = new Autocomplete
                {
                    Id = customerDto.Id,
                    Name = customerDto.Name
                };
                movies.Add(movie);
            }

            return Json(movies, JsonRequestBehavior.AllowGet);
        }
    }
}