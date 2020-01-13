using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("School Context")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        // Developers disagree about whether table names should be pluralized or singular.
        // In this tutorial we will use Student, Course, and Enrollment instead of
        // Strudents, Courses, and Enrollments bu using remove pluralizing table name conventions

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}