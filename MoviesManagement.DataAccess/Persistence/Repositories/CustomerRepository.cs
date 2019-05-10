using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataAccess.Core.Repositories;

namespace MoviesManagement.DataAccess.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PlutoContext context) : base(context)
        {
        }

        public IEnumerable<Customer> GetAllCustomersWithMembershipTypes()
        {
            return PlutoContext
                .Customers.Include(x => x.MembershipType);
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
