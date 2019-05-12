using System.Collections.Generic;
using MoviesManagement.DataContract;

namespace MoviesManagement.Web.ViewModels
{
    public class RentalFormViewModel
    {
        public CustomerDto Customer { get; set; }
        public MovieDto Movie { get; set; }
    }
}