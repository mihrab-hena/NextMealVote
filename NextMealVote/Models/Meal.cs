using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NextMealVote.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string MealType { get; set; }
    }
}