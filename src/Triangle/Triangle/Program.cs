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
            int[] lati = new int[3];

            for (int lato = 0; lato < lati.Length; lato++)
            {
                lati[lato] = AskAndCheckNumber("inserisci lato " + (lato + 1));
            }

            #region old code
            //int a = lati[0];
            //int b = lati[1];
            //int c = lati[2];

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

            //bool sumOk = a + b > c && b + c > a && c + a > b;
            //bool diffOk = a < Math.Abs(b - c) && b < Math.Abs(a - c) && c < Math.Abs(a - b);
            //if (sumOk && diffOk)
            //{
            //    Console.WriteLine("è un triangolo");
            //}
            //else
            //{
            //    Console.WriteLine("non è un triangolo");
            //}
            #endregion

            if (IsTriangle(lati[0], lati[1], lati[2]))
            {
                Console.WriteLine("è un triangolo");
            }
            else
            {
                Console.WriteLine("non è un triangolo");

                do {
                    int m = Math.Max(Math.Max(lati[0], lati[1]), lati[2]);

                    int index = Array.IndexOf(lati, m);

                    lati[index] = lati[index] - 1;
                }
                while (!IsTriangle(lati[0], lati[1], lati[2]));

                Console.WriteLine($"Questi valori invece costituiscono un triangolo {lati[0]}, {lati[1]}, {lati[2]}");
            }
            
            Console.ReadLine();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>True se i lati a, b, c possono costituire un tiangolo, False altrimenti.</returns>
        static bool IsTriangle(int a, int b, int c)
        {
            bool sumOk = a + b > c && b + c > a && c + a > b;
            bool diffOk = a > Math.Abs(b - c) && b > Math.Abs(a - c) && c > Math.Abs(a - b);

            return sumOk && diffOk;
        }
        /// <summary>
        /// Mostra all'utente il messaggio e prova
        /// convertire il valore inserito in input in un intero
        /// </summary>
        /// <param name="message">Messaggio mostrato all'utente</param>
        /// <returns>L'intero convertito a partire dalla stringa inserita dall'utente</returns>
        static int AskAndCheckNumber(string message)
        {
            System.Diagnostics.Debug.WriteLine(string.Concat("Message: ", message));
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool conversionOk = int.TryParse(input, out int convertedValue);
            if (!conversionOk)
                Console.WriteLine("l'input non è valido");

            if (convertedValue <= 0)
                Console.WriteLine("il valore deve essere positivo");

            //System.Diagnostics.Debug.WriteLine(string.Format("{0}: {1}", message, input));
            System.Diagnostics.Debug.WriteLine($"{ message }: { input }");

            return convertedValue;
        }
    }
}
