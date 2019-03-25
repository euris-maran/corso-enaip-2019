using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities {
	public interface IGamePlay {

		string Description { get; }
		void Run();
		void RegisterUIHandler(IUIHandler handler);
	}
}
