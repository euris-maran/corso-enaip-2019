using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities.RepoModes {
	static class AnagramExt {
		public static bool IsAnagram(this string word, string anagram) {
			if (word.Length != anagram.Length) {
				return false;
			}

			if (String.Concat(word.OrderBy(c => c)) == String.Concat(anagram.OrderBy(c => c))) {
				return true;
			}

			return false;
		}
	}

	abstract class ARepo: IRepository {
		public abstract string Description { get; }
		
		public List<string> GetAnagrams(string word) {
			var myDic = LoadDictionary();
			return myDic.Where(x => x.IsAnagram(word)).ToList();
		}

		public string GetRandomWord() {
			var myDic = LoadDictionary();
			return myDic[new Random().Next(0, myDic.Count)];
		}

		public bool IsAnagram(string word, string anagram) {
			return word.IsAnagram(anagram);
		}

		public abstract List<string> LoadDictionary();
	}
}
