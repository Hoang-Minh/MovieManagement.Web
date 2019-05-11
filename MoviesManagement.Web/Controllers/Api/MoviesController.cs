using System;
using System.Collections.Generic;
using System.Web.Http;
using MoviesManagement.DataContract;
using MoviesManagement.Management.Controllers;

namespace MoviesManagement.Web.Controllers.Api
{
    public class MoviesController : ApiController
    {
        [HttpGet]
        public IEnumerable<MovieDto> GetAllMovies()
        {
            var movieManagement = new MovieManagement();
            return movieManagement.GetAllMoviesWithGenres();
        }
    }
}
