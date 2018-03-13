using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bu =  Course.Business;

namespace CourseWebApi.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly bu.CoursesContext _context;

        public CoursesController(bu.CoursesContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<bu.Course> Get()
        {
            return _context.Courses.Include("Instructor").ToList();
        }
  
    }
}
