using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    public class LogEntry
    {
        public LogEntry()
        {
            Date = DateTime.Now;
        }
        //public class LogLevel
        //{
        //    public const int INFO = 0;
        //    public const int ERROR = 2;
        //}
        public enum LogLevel { Info, Warning, Error }

        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; }
        public Exception Error { get; set; }
    }
}
