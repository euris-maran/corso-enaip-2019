using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Repositories
{
    public class WordsRepository : IWordsRepository
    {
        readonly List<string> _words;

        public WordsRepository(IDictionaryLoader loader)
        {
            _words = loader.LoadDictionary();
        }

        public List<string> GetAnagrams(string word)
        {
            throw new NotImplementedException();
        }

        public string GetRandomWord()
        {
            throw new NotImplementedException();
        }

        public bool IsAnagram(string sourceWord, string candidateAnagram)
        {
            throw new NotImplementedException();
        }
    }
}
