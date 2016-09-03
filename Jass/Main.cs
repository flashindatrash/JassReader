using System;

namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			if (args.Length>0) {
				string file = args[0];
				Console.WriteLine(file);
			}
		}
	}
}
