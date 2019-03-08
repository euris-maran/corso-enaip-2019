using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass.Entities
{
    class School
    {
        List<Classroom> _classes = new List<Classroom>();

        public void AddClass(Classroom c)
        {
            _classes.Add(c);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> results = new List<Student>();
            foreach (var classroom in _classes)
            {
                results.AddRange(classroom.GetAllStudents());
            }

            return results;
        }

        public List<Student> SearchStudents(string name)
        {
            List<Student> results = new List<Student>();
            foreach (var classroom in _classes)
            {
                results.AddRange(classroom.SearchStudents(name));
            }

            return results;
        }

        public void AddStudent(int grade, Student student)
        {
            Classroom classroomFound = null;
            foreach (var classroom in _classes)
            {
                if (classroom.Grade == grade)
                {
                    classroomFound = classroom;
                    break;
                }
            }

            if (classroomFound == null)
            {
                classroomFound = new Classroom(grade);
                _classes.Add(classroomFound);
            }

            classroomFound.AddStudent(student);
        }

        public void RemoveStudent(int grade, string name)
        {
            List<Student> studentsFound = SearchStudents(name);
            foreach (var student in studentsFound)
            {
                if (student.AttendedClassroom.Grade == grade)
                {
                    student.AttendedClassroom.RemoveStudent(student);
                    break;
                }
            }
        }
    }
}
