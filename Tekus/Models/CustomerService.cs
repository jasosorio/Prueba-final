using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tekus.Models
{
    public class CustomerService
    {
        [key]
        public int CustomerServiceID { get; set; }
        public int CustomerID { get; set; }
        public int ServiceID { get; set; }     

        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }

        public virtual ICollection<CustomerServiceCountry> CustomerServiceCountries { get; set; }
    }
}