using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ContactManagement.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="Please enter last name")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage="Please enter valid email address")]
        public string Email { get; set; }
        [Phone(ErrorMessage="Please enter valid phone number")]
        public string Phone { get; set; }
        public bool Status { get; set; }
    }
}