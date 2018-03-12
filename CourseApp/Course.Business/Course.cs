using System;
using System.Collections.Generic;

namespace Course.Business
{
    public class Course
    {
        private List<Student> _enlistedStudents = new List<Student>();

        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public Instructor Instructor { get; set; }

        public IEnumerable<Student> EnlistedStudents => _enlistedStudents;

        public void Enlist(Student student)
        {
            _enlistedStudents.Add(student);
        }

    }
}
