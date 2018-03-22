using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NextMealVote.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ResidentialStatus { get; set; }

        public User User { get; set; }
    }
}