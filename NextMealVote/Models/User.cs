using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NextMealVote.Enum;

namespace NextMealVote.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        [Display(Name="User Role")]
        public UserRole UserRole { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [Display(Name = "Street Number")]
        public string StreetNumber { get; set; }
        [Display(Name = "Street Name")]
        public string StreetName { get; set; }
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        //public Address Address { get; set; }
        
    }

}