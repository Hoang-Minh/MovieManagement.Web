using System;
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
                .GetAllCustomersWithMembershipTypes()
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

        public void Add(CustomerDto customerDto)
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());
            var customer = mapper.Mapper.Map<CustomerDto, Customer>(customerDto);
            unitOfWork.Customers.Add(customer);
            unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            var unitOfWork = new UnitOfWork(new PlutoContext());
            var customerInDb = unitOfWork.Customers.Get(id);
            unitOfWork.Customers.Remove(customerInDb);
            unitOfWork.Complete();
        }

        public IEnumerable<CustomerDto> GetCustomersWithQuery(string query)
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());

            return unitOfWork
                .Customers
                .GetAllCustomersWithMembershipTypes()
                .Where(x => (x.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0))
                .Select(mapper.Mapper.Map<Customer, CustomerDto>)
                .Take(10);
        }
    }
}
