using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, List<string>> students = AskForStudents();

            PrintStudents(students);

            Console.ReadKey();
        }

        private static void PrintStudents(SortedDictionary<int, List<string>> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine($"Studenti della classe { item.Key }a");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"\t{item.Value[i]}");
                }
            }
        }

        static SortedDictionary<int, List<string>> AskForStudents()
        {
            SortedDictionary<int, List<string>> students = new SortedDictionary<int, List<string>>();

            do
            {
                string name = AskForName();
                int grade = AskForClass();
                AddStudent(students, name, grade);
            }
            while (NeedNext());

            return students;
        }

        private static void AddStudent(SortedDictionary<int, List<string>> students, string name, int grade)
        {
            if (!students.ContainsKey(grade))
                students[grade] = new List<string>();

            students[grade].Add(name);
        }

        private static bool NeedNext()
        {
            Console.WriteLine();
            Console.WriteLine("Vuoi inserire un altro studente? (S/N)");
            Console.WriteLine();

            return Console.ReadKey(true).Key == ConsoleKey.S;
        }

        static string AskForName()
        {
            Console.Write("Inserisci il nome: ");
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
