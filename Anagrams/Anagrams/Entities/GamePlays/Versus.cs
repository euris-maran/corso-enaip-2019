using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities.GamePlays {
	class Versus : IGamePlay {
		public string Description => "Versus";

		public void RegisterUIHandler(IUIHandler handler) {
			throw new NotImplementedException();
		}

		public void Run() {
			throw new NotImplementedException();
		}
	}
}
