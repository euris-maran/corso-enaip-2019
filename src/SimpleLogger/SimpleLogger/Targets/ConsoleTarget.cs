using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger.Targets
{
    public class ConsoleTarget : ILogTarget
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
