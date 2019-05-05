using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoviesManagement.Management.Controllers;

namespace MoviesManagement.Web.Controllers.Api
{
    public class MembershipTypesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetMembershipTypes()
        {
            var membershipTypes = new MembershipTypeManagement();
            var results = membershipTypes.GetMembershipType();

            return Ok(results);
        }
    }
}
