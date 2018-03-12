using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Models;
using bu = Course.Business;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CoursesViewModel
            {
                Courses = new List<bu.Course>
                {
                    new bu.Course
                    {
                        Name = "C# For Beginners",
                        StartDate = new DateTime(2018, 03, 23, 09, 00, 00),
                        Instructor = new bu.Instructor
                        {
                            Name = "Johan"
                        }
                    },

                    new bu.Course
                    {
                        Name = "Design Patterns for .NET Developers",
                        StartDate = new DateTime(2018, 03, 23, 12, 00, 00),
                        Instructor = new bu.Instructor
                        {
                            Name = "Johan"
                        }
                    },

                }
            };

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
