using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger.Targets
{
    public interface ILogTarget
    {
        void WriteLog(string message);
    }
}
