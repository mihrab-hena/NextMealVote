using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NextMealVote.Models;

namespace NextMealVote.Seed_Test_Data
{
    public class UserDBContextSeeder : DropCreateDatabaseIfModelChanges<UserDBContext>
    {
        protected override void Seed(UserDBContext context)
        {
            User user1 = new User()
            {
                FirstName = "Mihrab",
                LastName = "Hena",
                Email = "mihrabhena@gmail.com",
                UserRole = "Admin",
                Age = 28,
                Gender = "Male",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        StreetNumber = "189a",
                        StreetName = "Nieder-Ramstadter-Str",
                        PostCode = "64285",
                        City = "Darmstadt",
                        State = "Hesse",
                        Country = "Germany",
                        ResidentialStatus = "Current"
                    },
                    new Address()
                    {
                        StreetNumber = "62a",
                        StreetName = "West Agargaon",
                        PostCode = "1207",
                        City = "Darmstadt",
                        State = "",
                        Country = "Bangladesh",
                        ResidentialStatus = "Permanent"
                    }
                }
            };
            User user2 = new User()
            {
                FirstName = "Mohammod",
                LastName = "Zakaria",
                Email = "zakaria@gmail.com",
                UserRole = "user",
                Age = 34,
                Gender = "Male",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        StreetNumber = "45b",
                        StreetName = "Karlshof",
                        PostCode = "64398",
                        City = "Darmstadt",
                        State = "Hessen",
                        Country = "Germany",
                        ResidentialStatus = "Current"
                    }
                }
            };
            User user3 = new User()
            {
                FirstName = "Sonia",
                LastName = "Hena",
                Email = "sonia@yahoo.com",
                UserRole = "Chef",
                Age = 34,
                Gender = "Female",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        StreetNumber = "266",
                        StreetName = "Pulsen",
                        PostCode = "2223",
                        City = "Stockholm",
                        State = "",
                        Country = "Sweden",
                        ResidentialStatus = "Current"
                    }
                }
            };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);

            base.Seed(context);
        }
    }
}