using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFProject.Models
{
    public class Student
    {
        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime EnrollmentDate { set; get; }

    }
}