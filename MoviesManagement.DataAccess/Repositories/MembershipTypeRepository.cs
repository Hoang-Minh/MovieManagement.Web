using System.Collections.Generic;
using MoviesManagement.DataAccess.Models;

namespace MoviesManagement.DataAccess.Repositories
{
    public class MembershipTypeRepository : BaseRepository
    {
        public IEnumerable<MembershipType> GetMembershipTypes()
        {
            return DbContext.MembershipTypes;
        }
    }
}
