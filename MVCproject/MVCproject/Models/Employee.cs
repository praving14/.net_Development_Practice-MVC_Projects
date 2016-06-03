using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MVCproject.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
         public int EmployeeID { set; get; }
         public string Name { set; get; }
        public string Gender { set; get; }
        public string City { set; get; }
    }
}