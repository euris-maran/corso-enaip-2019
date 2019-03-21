using SimpleLogger;
using SimpleLogger.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTester
{
    class MockLogger : ILogger
    {
        public void AddTarget(ILogTarget target)
        {
            
        }

        public void LogError(string message, Exception e)
        {
            
        }

        public void LogInfo(string message)
        {
            
        }

        public void RemoveTarget(ILogTarget target)
        {
            
        }
    }
}
