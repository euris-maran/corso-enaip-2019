using SimpleLogger;
using SimpleLogger.Targets;

namespace LoggerTester
{
    internal class MockTarget : ILogTarget
    {
        public void WriteLog(LogEntry entry)
        {
            throw new System.NotImplementedException();
        }
    }
}