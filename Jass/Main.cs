namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			//Register Parser
			Core.RegisterParser(typeof(Globals), Globals.Pattern);
			Core.RegisterParser(typeof(EndGlobals), EndGlobals.Pattern);
			Core.RegisterParser(typeof(Function), Function.Pattern);
			Core.RegisterParser(typeof(Call), Call.Pattern);
			Core.RegisterParser(typeof(EndFunction), EndFunction.Pattern);
			Core.RegisterParser(typeof(EndIf), EndIf.Pattern);
			Core.RegisterParser(typeof(IfThen), IfThen.Pattern);
			Core.RegisterParser(typeof(Else), Else.Pattern);
			Core.RegisterParser(typeof(Return), Return.Pattern);
			Core.RegisterParser(typeof(Set), Set.Pattern);
			Core.RegisterParser(typeof(SetArray), SetArray.Pattern);
			Core.RegisterParser(typeof(Declaration), Declaration.Pattern);

			//Register Class
			Core.RegisterClass(ClassType.nothing, "void");
			Core.RegisterClass(ClassType.integer, "int");
			Core.RegisterClass(ClassType.boolean, "bool");

			using (JassWriter writer = new JassWriter())
			{
				writer.ClearFolder();

				using (JassReader reader = new JassReader())
				{
					string file = Settings.InputFolder + "Scripts\\common.ai";

					reader.Read(file);

					writer.Write(reader, File.Get(Settings.ClassTemplate));
				}
			}
		}
	}
}
