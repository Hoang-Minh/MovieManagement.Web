using System.Collections.Generic;
using System.Web.Http;
using MoviesManagement.DataContract;
using MoviesManagement.Management.Controllers;

namespace MoviesManagement.Web.Controllers.Api
{
    public class CustomersController : ApiController
    {
        [HttpGet]
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customerManagement = new CustomerManagement();
            return customerManagement.GetCustomersWithMembershipTypes();
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var customerManagement = new CustomerManagement();
            customerManagement.Delete(id);
        }
    }
}
