using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Games
{
    public interface IGameplay
    {
        void Run(IUIHandler uiHandler);

        String Description { get; }
    }
}
