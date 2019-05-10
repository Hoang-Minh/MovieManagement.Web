using System.Collections.Generic;
using MoviesManagement.DataAccess.Core.Domain;
using MoviesManagement.DataContract;

namespace MoviesManagement.Web.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerDto Customer { get; set; }
        public IList<CustomerDto> Customers { get; set; }

    }
}