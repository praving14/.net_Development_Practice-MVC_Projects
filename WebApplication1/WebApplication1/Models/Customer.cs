using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public enum Gender {
        Male,
        Female,
        Unknown
    }

    public class Customer
    {
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("ID")]
        public int CustomerID { set; get; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Name")]
        public string ContactName { set; get; }

        [Required(ErrorMessage = "This field is required")]
        public Gender gender { set; get; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Company")]
        public string CompanyName { set; get; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("MarriedStatus")]
        public bool isMarried{ set; get; }
    }

    
}