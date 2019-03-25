using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities.GamePlays {
	class Match : IGamePlay {
		public string Description => "Match";
		IUIHandler _uiHandler = null;

		public void RegisterUIHandler(IUIHandler handler) {
			_uiHandler = handler;
		}

		public void Run() {
			bool continua = true;
			while (continua) {
				_uiHandler.WriteMessage("- MATCH GAME -");
				_uiHandler.WriteMessage("La parola è: ");
				string randomWord = _uiHandler.WordRepository.GetRandomWord();
				_uiHandler.WriteMessage(randomWord);
				_uiHandler.WriteMessage("Inserisci un anagramma:");
				string answer =_uiHandler.AskForString();
				if (_uiHandler.WordRepository.IsAnagram(randomWord, answer)) {
					_uiHandler.WriteMessage("Bravo");
				}
				else {
					_uiHandler.WriteMessage("Peccato, risposta sbagliata");
				}

				_uiHandler.WriteMessage("Vuoi continuare? (s/n)");
				string continuare = _uiHandler.AskForString();
				continua = (continuare == "s");
			}
		}
	}
}
