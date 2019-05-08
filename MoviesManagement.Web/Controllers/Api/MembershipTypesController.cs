using System;
using System.Collections.Generic;
using System.Web.Http;
using MoviesManagement.DataContract;
using MoviesManagement.Management.Controllers;

namespace MoviesManagement.Web.Controllers.Api
{
    public class MembershipTypesController : ApiController
    {

        //GET /api/membershiptypes
        public IEnumerable<MembershipTypeDto> GetMembershipTypes()
        {
            var membershipTypeManagement = new MembershipTypeManagement();
            return membershipTypeManagement.GetMembershipType();
        }
    }
}
