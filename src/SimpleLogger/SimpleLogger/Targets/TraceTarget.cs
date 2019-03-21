using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger.Targets
{
    public class TraceTarget : ILogTarget
    {
        public void WriteLog(LogEntry entry)
        {
            Debug.WriteLine($"{entry.Level.ToString()} - {entry.Date.ToString()} - {entry.Message}");
            if (entry.Error != null)
            {
                Debug.WriteLine($"\t{entry.Error.Message}");
                Debug.WriteLine($"\t{entry.Error.StackTrace}");
            }
        }
    }
}
