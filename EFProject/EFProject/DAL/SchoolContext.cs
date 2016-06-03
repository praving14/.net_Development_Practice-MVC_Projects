using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EFProject.Models;

namespace EFProject.DAL
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base("SchoolContext") { }

        public DbSet<Student> Students { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}