using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            new ValueAndReference().Test();
            new Iterations().Iterate();
            new DataStructures().Array();

            //single row comment

            /*
             * Multirow comment
             */
             
            int i;
            short s;
            uint ui;
            long l;
            float f;
            double dd;
            decimal d;
            string st;
            char c;
            bool b;
            byte bt;

            i = 1;
            i = i + 1;
            //i = i++;
            //i = ++i;
            //i += 1;

         

            

            string str = "ciao";
            str = string.Concat(str, " Mario");

            var str2 = "ciao";
            var intero = 1;
            //str2 = 13467; errore

            Console.WriteLine(str);
            
            Console.ReadLine();
        }
    }
}
