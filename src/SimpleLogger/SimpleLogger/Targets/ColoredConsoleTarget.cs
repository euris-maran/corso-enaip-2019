using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger.Targets
{
    public class ColoredConsoleTarget : ILogTarget
    {
        public void WriteLog(LogEntry entry)
        {
            if (entry.Level == LogEntry.LogLevel.Error)
                Console.ForegroundColor = ConsoleColor.DarkRed;
            else if (entry.Level == LogEntry.LogLevel.Warning)
                Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"{entry.Level.ToString()} - {entry.Date.ToString()} - {entry.Message}");
            if (entry.Error != null)
            {
                Console.WriteLine($"\t{entry.Error.Message}");
                Console.WriteLine($"\t{entry.Error.StackTrace}");
            }
        }
    }
}
