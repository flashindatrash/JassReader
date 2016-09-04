using System;
using System.IO;

namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			Core.RegisterParser(typeof(FunctionStart), FunctionStart.InstanceOf);

			string file = "Scripts\\CreditsBlizzard.pld";

			if (args.Length>0) {
				file = args[0];
			}

			using (JassReader reader = new JassReader()) {
				Log.Add(string.Format("Read file: {0}", file), ConsoleColor.Blue);

				reader.Parse(File.ReadAllText(file));

				Log.Add(reader.ToString(ResultFormat.CSharp), ConsoleColor.Yellow);
			}

		}
	}
}
