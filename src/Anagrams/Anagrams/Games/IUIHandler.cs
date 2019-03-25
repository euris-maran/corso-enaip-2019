using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Games
{
    public interface IUIHandler
    {
        string AskForString(string message = "");

        int AskForInt(string message = "");

        void WriteMessage(string message = "");

        void Clear();
    }
}
