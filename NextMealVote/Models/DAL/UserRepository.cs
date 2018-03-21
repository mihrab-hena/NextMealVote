using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NextMealVote.Models.DAL
{
    public class UserRepository
    {
        public List<Address> GetAddresses()
        {
            UserDBContext userDbContext = new UserDBContext();
            return userDbContext.Addresses.ToList();
        }
    }
}