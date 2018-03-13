using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Course.Business
{
    public class CoursesContext : DbContext
    {

        public CoursesContext(DbContextOptions options) :
            base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Student> Students { get; set; }
     }
}
