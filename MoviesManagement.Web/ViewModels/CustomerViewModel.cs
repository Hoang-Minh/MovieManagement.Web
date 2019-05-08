using System.Collections.Generic;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.Web.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public IList<Customer> Customers { get; set; }

    }
}