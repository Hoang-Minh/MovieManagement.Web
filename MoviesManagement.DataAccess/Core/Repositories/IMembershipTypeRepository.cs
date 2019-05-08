using System.Collections.Generic;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.DataAccess.Core.Repositories
{
    public interface IMembershipTypeRepository : IRepository<MembershipType>
    {
        IEnumerable<MembershipType> GetAllMembershipTypes();
    }
}
