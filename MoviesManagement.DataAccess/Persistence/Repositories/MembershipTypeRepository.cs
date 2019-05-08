using System.Collections.Generic;
using System.Linq;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataAccess.Core.Repositories;

namespace MoviesManagement.DataAccess.Persistence.Repositories
{
    public class MembershipTypeRepository : Repository<MembershipType>, IMembershipTypeRepository
    {
        public MembershipTypeRepository(PlutoContext context) : base(context)
        {
        }

        public IEnumerable<MembershipType> GetAllMembershipTypes()
        {
            return PlutoContext.MembershipTypes.ToList();
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
        
    }
}
