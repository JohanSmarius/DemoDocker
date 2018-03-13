using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bu =  Course.Business;

namespace CourseWebApi.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<bu.Course> Get()
        {
            return new List<bu.Course>
            {
                new bu.Course
                {
                    Name = "C# For API Developers",
                    StartDate = new DateTime(2018, 03, 23, 09, 00, 00),
                    Instructor = new bu.Instructor
                    {
                        Name = "Johan"
                    }
                },

                new bu.Course
                {
                    Name = "Design Patterns for .NET WebAPI Developers",
                    StartDate = new DateTime(2018, 03, 23, 12, 00, 00),
                    Instructor = new bu.Instructor
                    {
                        Name = "Johan"
                    }
                },

            };
        }
  
    }
}
