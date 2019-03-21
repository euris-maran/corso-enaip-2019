using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLogger.Targets;

namespace SimpleLogger
{
    public class Logger : ILogger
    {
        readonly List<ILogTarget> _targets = new List<ILogTarget>();

        public void AddTarget(ILogTarget target)
        {
            _targets.Add(target);
        }

        public void RemoveTarget(ILogTarget target)
        {
            if (_targets.Contains(target))
                _targets.Remove(target);
        }

        public void LogError(string message, Exception e)
        {
            Log(new LogEntry
            {
                Level = LogEntry.LogLevel.Error,
                Message = message,
                Error = e
            });
        }

        public void LogInfo(string message)
        {
            Log(new LogEntry
            {
                Level = LogEntry.LogLevel.Info,
                Message = message
            });
        }

        private void Log(LogEntry entry)
        {
            foreach (ILogTarget target in _targets)
            {
                target.WriteLog(entry);
            }
        }
    }
}
