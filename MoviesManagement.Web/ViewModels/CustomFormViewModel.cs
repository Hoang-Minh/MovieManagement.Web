using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MoviesManagement.DataContract;

namespace MoviesManagement.Web.ViewModels
{
    public class CustomFormViewModel
    {
        public IEnumerable<MembershipTypeDto> MembershipTypes { get; set; }

        [Required(ErrorMessage = "Please enter a customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Select Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }
        
        [Display(Name = "Subscribed")]
        public bool IsSubscribedToNewsletter { get; set; }

        public string Title => Id == 0 ? "New" : "Edit Customer";
        public int Id { get; set; }

        public CustomFormViewModel()
        {
            Id = 0;
        }
        public CustomFormViewModel(CustomerDto customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            MembershipTypeId = customer.MembershipTypeId;
            //MembershipTypes = customer.MembershipType;
            Birthdate = customer.Birthdate;
        }
    }
}