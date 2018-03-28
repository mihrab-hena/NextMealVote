using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NextMealVote.Enum;

namespace NextMealVote.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public MealType MealType { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoName { get; set; }
        public List<string> ingredient { get; set; }
    }
}