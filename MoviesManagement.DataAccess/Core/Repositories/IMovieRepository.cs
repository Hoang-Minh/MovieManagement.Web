using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.DataAccess.Core.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetAllMoviesWithGenres();
    }
}
