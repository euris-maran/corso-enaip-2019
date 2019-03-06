using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClass
{
    class Program
    {
        static SortedDictionary<int, List<string>> students = new SortedDictionary<int, List<string>>();

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
            bool result = false;

            Console.WriteLine("Chi stai cercando?");
            string name = Console.ReadLine().Trim();
            var studentsFound = SearchStudents(name);

            if (studentsFound.Count == 0)
            {
                Console.WriteLine($"Non ho trovato { name } in nessuna classe");
            }
            else if (studentsFound.Count == 1)
            {
                result = RemoveStudent(studentsFound[0].Key, name);
            }
            else
            {
                Console.WriteLine("Ho trovato degli omonimi in più classi, da quale classe vuoi rimuovere lo studente?");
                foreach (var item in studentsFound)
                {
                    Console.WriteLine($"{ item.Value }, classe { item.Key }a");
                }

                int className = AskForClass();
                //test se la classe è corretta rispetto ai risultati
                result = RemoveStudent(className, name);
            }

            if (result)
                Console.WriteLine($"{name} è stato eliminato dagli studenti");
        }

        private static bool RemoveStudent(int className, string name)
        {
            students[className].Remove(name);

            if (students[className].Count == 0)
                students.Remove(className);

            return true;
        }

        private static void FindStudent()
        {
            Console.WriteLine("Chi stai cercando?");
            string name = Console.ReadLine().Trim();
            List<KeyValuePair<int, string>> studentsFound = SearchStudents(name);

            if (studentsFound.Count == 0)
            {
                Console.WriteLine($"Non ho trovato { name } in nessuna classe");
            }
            else
            {
                foreach (var entry in studentsFound)
                {
                    Console.WriteLine($"Ho trovato { entry.Value } nella classe { entry.Key }a");
                }
            }
        }

        private static List<KeyValuePair<int, string>> SearchStudents(string name)
        {
            List<KeyValuePair<int, string>> studentsFound = new List<KeyValuePair<int, string>>();
            foreach (var className in students)
            {
                foreach (var student in className.Value)
                {
                    if (student.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                        studentsFound.Add(new KeyValuePair<int, string>(className.Key, student));
                }
            }

            return studentsFound;
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
            foreach (var item in students)
            {
                Console.WriteLine($"Studenti della classe { item.Key }a");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"\t{item.Value[i]}");
                }
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
                    AddStudent(students, name, grade);
                }
            }
            while (!string.IsNullOrWhiteSpace(name));
        }

        private static void AddStudent(SortedDictionary<int, List<string>> students, string name, int grade)
        {
            if (!students.ContainsKey(grade))
                students[grade] = new List<string>();

            students[grade].Add(name);
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
