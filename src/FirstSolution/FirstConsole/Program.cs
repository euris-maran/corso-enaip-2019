using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
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

            if (i > 1 && i < 10 && i != 7)
            {

            }
            else if (i >= 2 || i == 5)
            {

            }
            else
            {

            }

            

            string str = "ciao";
            str = string.Concat(str, " Mario");

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
