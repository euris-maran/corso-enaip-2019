using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = AskAndCheckNumber("inserisci primo lato");
            int b = AskAndCheckNumber("inserisci secondo lato");
            int c = AskAndCheckNumber("inserisci terzo lato");
                        
            //Console.WriteLine("inserisci primo lato");
            //string input = Console.ReadLine();
            //bool conversionOk = int.TryParse(input, out a);
            //if (!conversionOk)
            //    Console.WriteLine("l'input non è valido");

            //Console.WriteLine("inserisci secondo lato");
            //input = Console.ReadLine();
            //conversionOk = int.TryParse(input, out  b);
            //if (!conversionOk)
            //    Console.WriteLine("l'input non è valido");

            //Console.WriteLine("inserisci terzo lato");
            //input = Console.ReadLine();
            //conversionOk = int.TryParse(input, out c);
            //if (!conversionOk)
            //    Console.WriteLine("l'input non è valido");

            bool sumOk = a + b > c && b + c > a && c + a > b;
            bool diffOk = a < Math.Abs(b - c) && b < Math.Abs(a - c) && c < Math.Abs(a - b);
            if (sumOk && diffOk)
            {
                Console.WriteLine("è un triangolo");
            }
            else
            {
                Console.WriteLine("non è un triangolo");
            }
            
            Console.ReadLine();
            
        }

        /// <summary>
        /// Mostra all'utente il messaggio e prova
        /// convertire il valore inserito in input in un intero
        /// </summary>
        /// <param name="message">Messaggio mostrato all'utente</param>
        /// <returns>L'intero convertito a partire dalla stringa inserita dall'utente</returns>
        static int AskAndCheckNumber(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool conversionOk = int.TryParse(input, out int convertedValue);
            if (!conversionOk)
                Console.WriteLine("l'input non è valido");

            if (convertedValue <= 0)
                Console.WriteLine("il valore deve essere positivo");

            return convertedValue;
        }
    }
}
