namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			//Register Parser
			Core.RegisterParser(typeof(Function), Function.Pattern);
			Core.RegisterParser(typeof(Call), Call.Pattern);
			Core.RegisterParser(typeof(EndFunction), EndFunction.Pattern);
			Core.RegisterParser(typeof(EndIf), EndIf.Pattern);
			Core.RegisterParser(typeof(Return), Return.Pattern);

			//Register Class
			Core.RegisterClass(ClassType.nothing, "void");
			Core.RegisterClass(ClassType.integer, "int");

			//Parse arguments
			string file = "Scripts\\h02_purple.ai";
			string template = "Templates\\SimpleClass.tpl";

			if (args.Length>0) file = args[0];
			if (args.Length > 1) template = args[1];

			//Create writer
			var writer = new JassWriter();
			writer.SetTemplate(System.IO.File.ReadAllText(template));

			//Read file
			using (JassReader reader = new JassReader()) {
				Log.Add(string.Format("Read file: {0}", file), System.ConsoleColor.Blue);

				reader.Parse(System.IO.File.ReadAllText(file));

				writer.Write(file, reader);
			}

		}
	}
}
