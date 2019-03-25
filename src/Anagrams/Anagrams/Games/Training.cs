using Anagrams.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Games
{
    public class Training : IGameplay
    {
        readonly IWordsRepository _words;

        public Training(IWordsRepository wordsRepository)
        {
            _words = wordsRepository;
        }

        public string Description => "Modalità di allenamento: inserisci una parola e l'applicazione restituisce i suoi anagrammi";

        public void Run(IUIHandler uiHandler)
        {
            do
            {
                uiHandler.Clear();

                string word = uiHandler.AskForString("Inserisci una parola di cui vuoi conoscere gli anagrammi:");

                var anagrams = _words.GetAnagrams(word);
                uiHandler.WriteMessage("Gli anagrammi trovati sono:");
                foreach (var anagram in anagrams)
                {
                    uiHandler.WriteMessage($"\t{anagram}");
                }
            }
            while (AnotherMatch(uiHandler));

            uiHandler.WriteMessage("Game over");
        }

        private bool AnotherMatch(IUIHandler uiHandler)
        {
            string choice = uiHandler.AskForString("Vuoi provare un'altra parola? (S/N)");
            return "S".Equals(choice, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
