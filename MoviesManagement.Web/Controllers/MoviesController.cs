using System.Web.Mvc;
using MoviesManagement.Management.Controllers;

namespace MoviesManagement.Web.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movieMangement = new MovieManagement();
            var movies = movieMangement.GetAllMoviesWithGenres();

            return View(movies);
        }
    }
}