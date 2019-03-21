using SimpleLogger;
using SimpleLogger.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            logger.AddTarget(new ConsoleTarget());

            logger.LogInfo("Messaggio informativo");
            logger.LogError("Errore", new Exception("Error"));

            Console.ReadKey(true);
        }
    }
}
