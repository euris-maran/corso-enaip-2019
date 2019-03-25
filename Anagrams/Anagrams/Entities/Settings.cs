using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams.Entities {
	class Settings {
		static Settings _instance = null;
		private Settings() {

		}
		public static Settings Instance{
			get {
				if (_instance is null) {
					_instance = new Settings();
				}
				return _instance;

			}
		}

		public IRepository Repository { get; set; }

	}
}
