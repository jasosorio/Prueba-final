using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tekus.Models
{
    public class CustomerServiceCountry
    {
        [Key]
        public int CustomerServiceCountryID { get; set; }
        public int CustomerServiceID { get; set; }
        public int CountryID { get; set; }

        public virtual CustomerService CustomerService { get; set; }
        public virtual Country Country { get; set; }
    }
}