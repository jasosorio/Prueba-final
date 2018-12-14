using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tekus.Models
{
    public class Country
    {
        [key]
        public int CountryID { get; set; }


        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string Description { get; set; }

        public virtual ICollection<CustomerServiceCountry> CustomerServiceCountries { get; set; }
    }
}