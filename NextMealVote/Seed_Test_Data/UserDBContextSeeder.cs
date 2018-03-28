using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NextMealVote.Enum;
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
                UserRole = UserRole.Admin,
                Age = 28,
                Gender = Gender.Male,
                StreetNumber = "",
                StreetName = "",
                PostCode = "",
                City = "",
                Country = ""

                //Addresses = new List<Address>()
                //{
                //    new Address()
                //    {
                //        StreetNumber = "189a",
                //        StreetName = "Nieder-Ramstadter-Str",
                //        PostCode = "64285",
                //        City = "Darmstadt",
                //        State = "Hesse",
                //        Country = "Germany",
                //        ResidentialStatus = "Current"
                //    },
                //    new Address()
                //    {
                //        StreetNumber = "62a",
                //        StreetName = "West Agargaon",
                //        PostCode = "1207",
                //        City = "Darmstadt",
                //        State = "",
                //        Country = "Bangladesh",
                //        ResidentialStatus = "Permanent"
                //    }
                //}
            };
            User user2 = new User()
            {
                FirstName = "Mohammod",
                LastName = "Zakaria",
                Email = "zakaria@gmail.com",
                UserRole = UserRole.User,
                Age = 34,
                Gender = Gender.Unknown,
                StreetNumber = "45",
                StreetName = "Karlshof",
                PostCode = "6538",
                City = "Darmstadt",
                Country = "Germany"
                //Addresses = new List<Address>()
                //{
                //    new Address()
                //    {
                //        StreetNumber = "45b",
                //        StreetName = "Karlshof",
                //        PostCode = "64398",
                //        City = "Darmstadt",
                //        State = "Hessen",
                //        Country = "Germany",
                //        ResidentialStatus = "Current"
                //    }
                //}
            };
            User user3 = new User()
            {
                FirstName = "Sonia",
                LastName = "Hena",
                Email = "sonia@yahoo.com",
                UserRole = UserRole.Chef,
                Age = 34,
                Gender = Gender.Female,
                StreetNumber = "3777",
                StreetName = "Hudingge",
                PostCode = "Sw88",
                City = "Stockholm",
                Country = "Sweden"
                //Addresses = new List<Address>()
                //{
                //    new Address()
                //    {
                //        StreetNumber = "266",
                //        StreetName = "Pulsen",
                //        PostCode = "2223",
                //        City = "Stockholm",
                //        State = "",
                //        Country = "Sweden",
                //        ResidentialStatus = "Current"
                //    }
                //}
            };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);

            Meal meal1 = new Meal()
            {
                Name = "Sandwich",
                Price = 150,
                MealType = MealType.Breakfast,
                PhotoPath = "~/Photos/Meal_Photos/SampleMeal.png",
                PhotoName = "SampleMealPhoto",
                ingredient = new List<string>()
                {
                    "chicken",
                    "Cucumber",
                    "Tomato",
                    "Egg"
                }
            };

            context.Meals.Add(meal1);

            base.Seed(context);
        }
    }
}