using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Course.Business
{
    public class CoursesContextFactory : IDesignTimeDbContextFactory<CoursesContext>
    {
        public CoursesContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CoursesContext>();
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database = Courses; Trusted_Connection = True; MultipleActiveResultSets = true");

            return new CoursesContext(optionsBuilder.Options);
        }
    }
}
