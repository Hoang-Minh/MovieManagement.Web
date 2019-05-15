using System.Collections.Generic;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.DataAccess.Core.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetAllMoviesWithGenres();
    }
}
