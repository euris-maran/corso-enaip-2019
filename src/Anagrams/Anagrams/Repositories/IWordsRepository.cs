using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Repositories
{
    public interface IWordsRepository
    {
        /// <summary>
        /// Restituisce gli anagrammi di una parola
        /// </summary>
        /// <param name="word">La parola da utilizzare per ricercare gli anagrammi</param>
        /// <returns>La lista di parole anagrammi della passata</returns>
        List<string> GetAnagrams(string word);

        /// <summary>
        /// Verifica se una parola è un anagramma di un'altra
        /// </summary>
        /// <param name="sourceWord">Parola da utilizzare come sorgente</param>
        /// <param name="candidateAnagram">Parola da utilizzare come verifica</param>
        /// <returns>True se la candidateWord è un anagramma della sourceWord, False altrimenti</returns>
        bool IsAnagram(string sourceWord, string candidateAnagram);

        /// <summary>
        /// Restituisce dal dizionario una parola casuale che abbia anagrammi
        /// </summary>
        /// <returns></returns>
        string GetRandomWord();
    }
}
