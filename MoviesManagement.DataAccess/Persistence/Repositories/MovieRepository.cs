using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataAccess.Core.Repositories;

namespace MoviesManagement.DataAccess.Persistence.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(PlutoContext context) : base(context)
        {
        }

        public IEnumerable<Movie> GetAllMoviesWithGenres()
        {
            return PlutoContext
                .Movies.Include(x => x.Genre);
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
