using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities {
	public interface IRepository {
		string Description { get; }

		List<string> LoadDictionary();
		List<string> GetAnagrams(string word);
		string GetRandomWord();
		bool IsAnagram(string sourceWord, string possibleAnagram);
	}
}
