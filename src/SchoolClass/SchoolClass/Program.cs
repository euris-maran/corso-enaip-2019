using SchoolClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    class Program
    {
        static School _school = new School();
        
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                PrintMenu();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.C:
                        ClearScreen();
                        break;
                    case ConsoleKey.I:
                        AskForStudents();
                        break;
                    case ConsoleKey.L:
                        PrintStudents();
                        break;
                    case ConsoleKey.F:
                        FindStudent();
                        break;
                    case ConsoleKey.R:
                        DeleteStudent();
                        break;
                    case ConsoleKey.Escape:
                        run = false;
                        break;
                }
            }

            Console.ReadKey();
        }

        private static void ClearScreen()
        {
            Console.Clear();
        }

        private static void DeleteStudent()
        {
            Console.WriteLine("Chi stai cercando?");
            string name = Console.ReadLine().Trim();

            var studentsFound = _school.SearchStudents(name);
            if (studentsFound.Count == 0)
            {
                Console.WriteLine($"Non ho trovato { name } in nessuna classe");
            }
            else if (studentsFound.Count == 1)
            {
                _school.RemoveStudent(studentsFound[0].AttendedClassroom.Grade, studentsFound[0].Name);
                Console.WriteLine($"{name} è stato eliminato dagli studenti");
            }
            else
            {
                Console.WriteLine("Ho trovato degli omonimi in più classi, da quale classe vuoi rimuovere lo studente?");
                foreach (var student in studentsFound)
                {
                    Console.WriteLine($"{ student.Name }, classe { student.AttendedClassroom.Grade }a");
                }

                int className = AskForClass();
                //TODO test se la classe è corretta rispetto ai risultati
                _school.RemoveStudent(className, name);

                Console.WriteLine($"{name} è stato eliminato dagli studenti");
            }
        }

        class StudentForNameFilter : IFilter
        {
            readonly string _name;
            public StudentForNameFilter(string name)
            {
                _name = name;
            }

            public bool Filter(Student s)
            {
                return s.Name.Equals(_name, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        static string nameFilter;

        private static bool FilterByName(Student student)
        {
            return student.Name.Equals(nameFilter, StringComparison.InvariantCultureIgnoreCase);
        }

        private static void FindStudent()
        {
            Console.WriteLine("Chi stai cercando?");
            string name = Console.ReadLine().Trim();
            nameFilter = name;
            //var studentsFound = _school.Classes[0].SearchStudents(new StudentForNameFilter(name));
            
            var studentsFound = _school.Classes[0].SearchStudents(FilterByName);

            if (studentsFound.Count == 0)
            {
                Console.WriteLine($"Non ho trovato { name } in nessuna classe");
            }
            else
            {
                foreach (var entry in studentsFound)
                {
                    Console.WriteLine($"Ho trovato { entry.Name } nella classe { entry.AttendedClassroom.Grade }a");
                }
            }
        }
        
        private static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Seleziona funzionalità:");
            Console.WriteLine("  Inserimento studenti (I)");
            Console.WriteLine("  Visualizza lista classi (L)");
            Console.WriteLine("  Cerca uno studente (F)");
            Console.WriteLine("  Rimuove uno studente (R)");
            Console.WriteLine();
            Console.WriteLine("  Escape per uscire");
            Console.WriteLine("  C per pulire la console");
            Console.WriteLine();
        }

        private static void PrintStudents()
        {
            foreach (var student in _school.GetAllStudents())
            {
                Console.WriteLine($"Studente { student.Name } appartenente alla classe { student.AttendedClassroom.Grade }a");
            }
        }

        static void AskForStudents()
        {
            string name;
            do
            {
                name = AskForName();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    int grade = AskForClass();
                    _school.AddStudent(grade, new Student(name));
                }
            }
            while (!string.IsNullOrWhiteSpace(name));
        }

        static string AskForName()
        {
            Console.Write("Inserisci il nome (enter per uscire): ");
            return Console.ReadLine();
        }

        static int AskForClass()
        {
            bool inputOk = false;
            int grade = 0;

            while (!inputOk)
            {
                Console.Write("Inserisci la classe: ");
                string gradeStr = Console.ReadLine();

                if (int.TryParse(gradeStr, out grade) && grade > 0 && grade <= 5)
                {
                    inputOk = true;
                }
                else
                {
                    Console.WriteLine("Classe non valida: deve essere un intero fra 1 e 5");
                }
            }

            return grade;
        }
    }
}
