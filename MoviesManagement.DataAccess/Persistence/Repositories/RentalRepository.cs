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
    public class RentalRepository : Repository<Rental>, IRentalRepository
    {
        public RentalRepository(PlutoContext context) : base(context)
        {
        }

        public IEnumerable<Rental> GetAllMoviesWithIds(int id)
        {
            return PlutoContext
                .Rentals
                .Where(x => x.Movie.Id == id);
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
