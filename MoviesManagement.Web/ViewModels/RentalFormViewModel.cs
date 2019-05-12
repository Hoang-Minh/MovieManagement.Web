using System.Collections.Generic;
using MoviesManagement.DataContract;

namespace MoviesManagement.Web.ViewModels
{
    public class RentalFormViewModel
    {
        public IEnumerable<CustomerDto> Customers { get; set; }
        public IEnumerable<MovieDto> Movies { get; set; }
    }
}