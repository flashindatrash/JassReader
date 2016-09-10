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
			Core.RegisterParser(typeof(Loop), Loop.Pattern);
			Core.RegisterParser(typeof(EndLoop), EndLoop.Pattern);
			Core.RegisterParser(typeof(ExitWhen), ExitWhen.Pattern);
			Core.RegisterParser(typeof(Set), Set.Pattern);
			Core.RegisterParser(typeof(SetArray), SetArray.Pattern);
			Core.RegisterParser(typeof(Declaration), Declaration.Pattern);

			//Register Class
			Core.RegisterClass(ClassType.nothing, new ClassInfo("void"));
			Core.RegisterClass(ClassType.integer, new ClassInfo("int", "0"));
			Core.RegisterClass(ClassType.boolean, new ClassInfo("bool", "false"));
			Core.RegisterClass(ClassType.unit, new ClassInfo("int", "0")); //delete

			using (JassWriter writer = new JassWriter())
			{
				writer.ClearFolder();

				using (JassReader reader = new JassReader())
				{
					reader.Read("Scripts\\common.ai");

					writer.CreateFile(new JassFormatter(reader.result, reader.file, Settings.ClassTemplate));
				}

				writer.CreateFile(new JassFormatter(JassReader.globals, "Globals", Settings.GlobalsTemplate));
				writer.CreateFile(new JassFormatter(JassReader.native, "Api", Settings.ApiTemplate));
			}
		}
	}
}
