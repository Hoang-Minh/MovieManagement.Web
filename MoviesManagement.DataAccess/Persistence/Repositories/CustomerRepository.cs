using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public Customer GetCustomer(int id)
        {
            return PlutoContext
                    .Customers
                    .Find(id);
        }

        public PlutoContext PlutoContext => Context as PlutoContext;
    }
}
