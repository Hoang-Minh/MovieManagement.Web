using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.DataAccess;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataContract;

namespace MoviesManagement.Management.Controllers
{
    public class CustomerManagement
    {
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var mapper = new MappingProfile();
            var unitOfWork = new UnitOfWork(new PlutoContext());
            return unitOfWork
                .Customers
                .GetAllCustomers().ToList()
                .Select(mapper.Mapper.Map<Customer, CustomerDto>);
        }
    }
}
