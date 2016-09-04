using System;

namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			Core.RegisterClass(typeof(Jass.Function));
			Core.RegisterClass(typeof(Jass.String));

			string file = "Scripts\\CreditsBlizzard.pld";

			if (args.Length>0) {
				file = args[0];
			}

			using (JassReader reader = new JassReader()) {
				reader.Read(file);
			}

		}
	}
}
