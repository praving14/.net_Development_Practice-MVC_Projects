using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFProject.Models;

namespace EFProject.DAL
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {

        protected override void Seed(SchoolContext context)
        {
            List<Student> students = new List<Student> {
              new Student{FirstName="Carson", LastName = "Alexander", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Meredith",  LastName="Alonso", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Arturo", LastName = "Anand", EnrollmentDate = DateTime.Parse("2003-09-01")},
                new Student{FirstName="Gytis", LastName="Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01")},
                new Student{FirstName="Yan", LastName="Li", EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Peggy", LastName="Justice", EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Laura", LastName="Norman", EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nino", LastName="Olivetto", EnrollmentDate=DateTime.Parse("2005-09-01")}
          };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }

    }
}