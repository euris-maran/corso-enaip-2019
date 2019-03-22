using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass.Entities
{
    public class Student
    {
        public Student(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public string Surname { get; set; }

        public Classroom AttendedClassroom { get; private set; }

        public void RegisterForAttendance(Classroom c)
        {
            AttendedClassroom = c;
        }

        internal void UnregisterForAttendance(Classroom classroom)
        {
            if (classroom == AttendedClassroom)
                AttendedClassroom = null;
        }
    }
}
