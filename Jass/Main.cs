namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			//Register Parser
			Core.RegisterParser(typeof(Function), Function.Pattern);
			Core.RegisterParser(typeof(Call), Call.Pattern);
			Core.RegisterParser(typeof(EndFunction), EndFunction.Pattern);

			//Register Class
			Core.RegisterClass(ClassType.nothing, "void");

			//Get file
			string file = "Scripts\\CreditsBlizzard.pld";

			if (args.Length>0) {
				file = args[0];
			}

			//Read file
			using (JassReader reader = new JassReader()) {
				Log.Add(string.Format("Read file: {0}", file), System.ConsoleColor.Blue);

				reader.Parse(System.IO.File.ReadAllText(file));

				Log.Add(reader.ToString(), System.ConsoleColor.Yellow);
			}

		}
	}
}
