using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger.Targets
{
    public class ConsoleTarget : ILogTarget
    {
        public void WriteLog(LogEntry entry)
        {
            Console.WriteLine($"{entry.Level.ToString()} - {entry.Date.ToString()} - {entry.Message}");
            if (entry.Error != null)
            {
                Console.WriteLine($"\t{entry.Error.Message}");
                Console.WriteLine($"\t{entry.Error.StackTrace}");
            }
        }
    }
}
