using System.Collections.Generic;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.DataAccess.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<Customer> GetAllCustomersWithMembershipTypes();
    }
}
