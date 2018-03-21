using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NextMealVote.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public List<Address> Addresses { get; set; }
        
    }
}