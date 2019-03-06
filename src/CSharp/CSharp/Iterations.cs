using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Iterations
    {
        public void Iterate()
        {
            int i = 0;
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Sono nell'iterazione " + (i + 1));
                if (i == 5)
                    continue;

                if (i == 7)
                    break;

                Console.WriteLine(i);
                System.Diagnostics.Debug.WriteLine(i);
            }

            for (i = 3; i > 0; i--)
            {
                System.Diagnostics.Debug.WriteLine(i);
            }

            i = 0;
            while (i < 3)
            {
                System.Diagnostics.Debug.WriteLine(i);
                if (i == 2)
                    break;
                i++;
            }

            i = 0;
            do
            {
                System.Diagnostics.Debug.WriteLine(i);
                i++;
            } while (i < 3);
        }
    }
}
