using System.Collections.Generic;
using System.Linq;
using MoviesManagement.DataAccess;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataContract;

namespace MoviesManagement.Management.Controllers
{
    public class MembershipTypeManagement
    {
        public IEnumerable<MembershipTypeDto> GetMembershipType()
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());
            return unitOfWork
                .MembershipTypes
                .GetAll().ToList()
                .Select(mapper.Mapper.Map<MembershipType, MembershipTypeDto>);
        }
    }
}
