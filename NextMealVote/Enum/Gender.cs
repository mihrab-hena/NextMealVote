using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NextMealVote.Enum
{
    public enum Gender
    {
        Male,
        Female,
        [Display(Name = "Prefer not to say")]
        Unknown
    }
}