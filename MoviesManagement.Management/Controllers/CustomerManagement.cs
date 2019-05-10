using System.Collections.Generic;
using System.Linq;
using MoviesManagement.DataAccess;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataContract;

namespace MoviesManagement.Management.Controllers
{
    public class CustomerManagement
    {
        public IEnumerable<CustomerDto> GetCustomersWithMembershipTypes()
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());
            return unitOfWork
                .Customers
                .GetAllCustomersWithMembershipTypes().ToList()
                .Select(mapper.Mapper.Map<Customer, CustomerDto>);
        }

        public CustomerDto GetCustomerWithMembershipTypes(int id)
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());
            var customerInDb = unitOfWork
                .Customers
                .GetAllCustomersWithMembershipTypes()
                .Single(x => x.Id == id);
            var customerDto = mapper.Mapper.Map<Customer, CustomerDto>(customerInDb);
            return customerDto;
        }

        public void AddOrUpdate(CustomerDto customer)
        {

        }
    }
}
