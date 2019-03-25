using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities.RepoModes {
	class MemoryRepo : ARepo {
		public override string Description => "In memory data.";
		
		public override List<string> LoadDictionary() {
			List<string> lstOut = new List<string>();
			lstOut.Add("vela");
			lstOut.Add("lave");
			lstOut.Add("leva");
			lstOut.Add("vale");
			lstOut.Add("nave");
			lstOut.Add("neva");
			lstOut.Add("vane");
			lstOut.Add("vena");

			return lstOut;
		}
	}
}
