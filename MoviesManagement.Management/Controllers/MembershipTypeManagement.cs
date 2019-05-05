using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.DataAccess.Models;
using MoviesManagement.DataAccess.Repositories;
using MoviesManagement.DataContract;

namespace MoviesManagement.Management.Controllers
{
    public class MembershipTypeManagement
    {
        public IEnumerable<MembershipTypeDto> GetMembershipType()
        {
            var repo = new MembershipTypeRepository();
            var membershipTypes = repo.GetMembershipTypes().ToList();
            var mapperProfile = new MappingProfile();

            var membershipTypeDto = membershipTypes.Select(mapperProfile.Mapper.Map<MembershipType, MembershipTypeDto>);

            return membershipTypeDto;
        }
    }
}
