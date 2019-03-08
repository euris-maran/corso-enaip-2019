using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass.Entities
{
    public class Classroom
    {
        List<Student> _students = new List<Student>();

        public Classroom(int grade)
        {
            Grade = grade;
        }
        
        public int Grade { get; }

        public void AddStudent(Student student)
        {
            _students.Add(student);
            student.RegisterForAttendance(this);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
            student.UnregisterForAttendance(this);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> results = new List<Student>();
            foreach (var student in _students)
            {
                results.Add(student);
            }

            return results;
        }

        public List<Student> SearchStudents(string name)
        {
            List<Student> results = new List<Student>();
            foreach (var student in _students)
            {
                if (student.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                    results.Add(student);
            }

            return results;
        }
    }
}
