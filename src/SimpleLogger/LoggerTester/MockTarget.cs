using SimpleLogger.Targets;

namespace LoggerTester
{
    internal class MockTarget : ILogTarget
    {
        public void WriteLog(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}