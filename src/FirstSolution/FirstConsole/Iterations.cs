using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Iterations
    {
        void Iterate()
        {
            int i = 0;
            for (i = 0; i < 3; i++)
            {
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
