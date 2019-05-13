using System;
using System.Collections.Generic;
using System.Linq;
using MoviesManagement.DataAccess;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataContract;

namespace MoviesManagement.Management.Controllers
{
    public class MovieManagement
    {
        public IEnumerable<MovieDto> GetAllMoviesWithGenres()
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());

            return unitOfWork
                .Movies
                .GetAllMoviesWithGenres().ToList()
                .Select(mapper.Mapper.Map<Movie, MovieDto>);
        }

        public IEnumerable<MovieDto> GetMoviesWithQuery(string query)
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());

            return unitOfWork
                .Movies
                .GetAllMoviesWithGenres()
                .Where(x => (x.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0))
                .Select(mapper.Mapper.Map<Movie, MovieDto>)
                .Take(10);
        }
    }
}
