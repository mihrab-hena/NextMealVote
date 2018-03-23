using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NextMealVote.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required]
        public string UserRole { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public List<Address> Addresses { get; set; }
        
    }
}