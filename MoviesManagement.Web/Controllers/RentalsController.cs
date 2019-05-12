using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesManagement.Management.Controllers;
using MoviesManagement.Web.ViewModels;

namespace MoviesManagement.Web.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            var customerManagement = new CustomerManagement();
            var customers = customerManagement.GetCustomersWithMembershipTypes();
            
            var movieManagement = new MovieManagement();
            var movies = movieManagement.GetAllMoviesWithGenres();
            var rentalFormViewModel = new RentalFormViewModel
            {
                Customers = customers,
                Movies = movies
            };

            return View(rentalFormViewModel);
        }

        [HttpPost]
        public ActionResult Save()
        {

            return View();
        }
    }
}