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
            return _words.Where(w => w.Length == word.Length && IsAnagram(w, word)).ToList();
        }

        public string GetRandomWord(int minimumAnagrams = 1)
        {
            string word = null;
            do
            {
                Random r = new Random(DateTime.Now.Millisecond);

                string candidateWord = _words[r.Next(_words.Count)];
                System.Diagnostics.Debug.WriteLine($"Testing {candidateWord}");
                if (GetAnagrams(candidateWord).Count >= minimumAnagrams)
                    word = candidateWord;
            }
            while (string.IsNullOrEmpty(word));

            return word;
        }

        public bool IsAnagram(string sourceWord, string candidateAnagram)
        {
            
            if (sourceWord == candidateAnagram)
                return false;

            if (sourceWord.Length != candidateAnagram.Length)
                return false;

            var lowerSourceChars = sourceWord.ToLower().OrderBy(c => c).ToArray();
            var lowerCandidateChars = candidateAnagram.ToLower().OrderBy(c => c).ToArray();

            for (int i = 0; i < lowerSourceChars.Length; i++)
            {
                if (lowerCandidateChars[i] > lowerSourceChars[i])
                    return false;
            }

            string testSourceOrdered = new string(lowerSourceChars);
            string testCandidateOrdered = new string(lowerCandidateChars);

            return testCandidateOrdered == testSourceOrdered && _words.Contains(candidateAnagram);
        }
    }
}
