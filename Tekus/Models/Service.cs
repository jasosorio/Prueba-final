using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tekus.Models
{
    public class Service
    {
        [key]
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(50, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string Description { get; set; }

        [Display(Name = "Price Per Hour")]
        [Required(ErrorMessage = "You must enter {0}")]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        public decimal PricePerHour { get; set; }

        public virtual ICollection<CustomerService> CustomerServices { get; set; }
    }
}