using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities.RepoModes {
	class FileRepo : ARepo {
		readonly string _dictionaryPath = string.Concat(
			Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
			Path.DirectorySeparatorChar,
			"Entities",
			Path.DirectorySeparatorChar,
			"RepoModes",
			Path.DirectorySeparatorChar,
			"660000_parole_italiane.txt");

		public override string Description => "Carica da file";


		public override List<string> LoadDictionary() {
			try {
				return File.ReadAllLines(_dictionaryPath).ToList();
			}
			catch (Exception e) {
				throw new Exception($"Error reading file { _dictionaryPath }", e);
			}
		}
	}
}
