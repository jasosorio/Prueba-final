using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tekus.Models
{
    public class Customer
    {
        [key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        public int Nit { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<CustomerService> CustomerServices { get; set; }
    }
}