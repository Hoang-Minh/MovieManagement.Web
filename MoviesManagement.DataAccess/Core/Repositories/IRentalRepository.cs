using System.Collections.Generic;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.DataAccess.Core.Repositories
{
    public interface IRentalRepository : IRepository<Rental>
    {
        IEnumerable<Rental> GetAllMoviesWithIds(int id);
    }
}
