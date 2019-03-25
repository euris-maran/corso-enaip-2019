using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities.GamePlays {
	class Practice : IGamePlay {
		private IUIHandler _uiHandler;

		public string Description => "Practice";

		public void RegisterUIHandler(IUIHandler handler) {
			_uiHandler = handler;
		}

		public void Run() {
			bool continua = true;
			while (continua) {
				_uiHandler.WriteMessage("- PRACTICE GAME -");
				_uiHandler.WriteMessage("Inserisci una parola di prova");
				string myWord = _uiHandler.AskForString();
				var anagrams = _uiHandler.WordRepository.GetAnagrams(myWord);
				foreach (var anag in anagrams) {
					_uiHandler.WriteMessage(anag);
				}

				_uiHandler.WriteMessage("Vuoi continuare? (s/n)");
				string continuare =_uiHandler.AskForString();
				continua = (continuare == "s");
			}
		}
	}
}
