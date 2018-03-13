using System;
using System.Collections.Generic;

namespace Course.Business
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public Instructor Instructor { get; set; }

        public int InstructorId { get; set; }
    }
}
