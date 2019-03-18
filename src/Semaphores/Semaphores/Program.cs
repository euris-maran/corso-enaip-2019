using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaphores
{
    class Program
    {
        static void Main(string[] args)
        {
            CrossroadController c = new CrossroadController(5, 1);
            Console.WriteLine(c.StateDescription);

            while (true)
            {
                int timing = c.NextState();
                Console.WriteLine(c.StateDescription);
                System.Threading.Thread.Sleep(timing * 1000);
            }

        }
    }
}
