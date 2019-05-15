using System;
using System.ComponentModel.DataAnnotations;
using MoviesManagement.DataContract;

namespace MoviesManagement.Web.ViewModels
{
    public class RentalFormViewModel
    {
        public CustomerDto Customer { get; set; }
        public MovieDto Movie { get; set; }

        [Required(ErrorMessage = "Please enter a customer's name")]
        [Display(Name = "Customer's Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter a movie's title")]
        [Display(Name = "Movie's Title")]
        public string MovieName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}