namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			//Register Parser
			Core.RegisterParser(new LineInfo(typeof(Globals), Globals.Pattern));
			Core.RegisterParser(new LineInfo(typeof(EndGlobals), EndGlobals.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Function), Function.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Call), Call.Pattern));
			Core.RegisterParser(new LineInfo(typeof(EndFunction), EndFunction.Pattern));
			Core.RegisterParser(new LineInfo(typeof(EndIf), EndIf.Pattern));
			Core.RegisterParser(new LineInfo(typeof(IfThen), IfThen.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Else), Else.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Return), Return.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Loop), Loop.Pattern));
			Core.RegisterParser(new LineInfo(typeof(EndLoop), EndLoop.Pattern));
			Core.RegisterParser(new LineInfo(typeof(ExitWhen), ExitWhen.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Set), Set.Pattern));
			Core.RegisterParser(new LineInfo(typeof(SetArray), SetArray.Pattern));
			Core.RegisterParser(new LineInfo(typeof(Declaration), Declaration.Pattern));

			//Register Class
			Core.RegisterClass(ClassType.nothing, new ClassInfo("void"));
			Core.RegisterClass(ClassType.integer, new ClassInfo("int", "0"));
			Core.RegisterClass(ClassType.boolean, new ClassInfo("bool", "false"));
			Core.RegisterClass(ClassType.real, new ClassInfo("float", "0f"));
			Core.RegisterClass(ClassType.unit, new ClassInfo("int", "0")); //delete

			using (JassWriter writer = new JassWriter())
			{
				writer.ClearFolder();

				using (JassReader reader = new JassReader())
				{
					string[] files = reader.GetAllFiles();
					foreach (string file in files)
					{
						var lines = reader.Read(file);
						writer.CreateFile(new JassFormatter(lines, file, Settings.ClassTemplate));
						//break;
					}
				}

				writer.CreateFile(new JassFormatter(JassReader.globals, "Globals", Settings.GlobalsTemplate));
				writer.CreateFile(new JassFormatter(JassReader.native, "Api", Settings.ApiTemplate));
			}
		}
	}
}
