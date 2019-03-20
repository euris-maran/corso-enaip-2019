using SimpleLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTester
{
    class MockLogger : ILogger
    {
        public void LogError(string message, Exception e)
        {
            
        }

        public void LogInfo(string message)
        {
            
        }
    }
}
