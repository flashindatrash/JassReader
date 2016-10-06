namespace Jass {
	class MainClass {
		public static void Main (string[] args) {
			//Register Parser
			Pattern.RegisterParser(new Pattern(typeof(Debug), Debug.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Extends), Extends.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Globals), Globals.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(EndGlobals), EndGlobals.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Function), Function.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Call), Call.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(EndFunction), EndFunction.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(EndIf), EndIf.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(IfThen), IfThen.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Else), Else.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Return), Return.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Loop), Loop.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(EndLoop), EndLoop.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(ExitWhen), ExitWhen.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Set), Set.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(SetArray), SetArray.Pattern));
			Pattern.RegisterParser(new Pattern(typeof(Declaration), Declaration.Pattern));

			using (JassWriter writer = new JassWriter())
			{
				writer.ClearFolder();

				JassFile[] files;

				using (JassReader reader = new JassReader())
				{
					files = reader.ReadAll();
				}

				foreach (JassFile file in files)
				{
					writer.CreateFile(file);
				}

				writer.CreateFile(new TemplateFile(Settings.ArrayTemplate));
			}

			Log.Add("done");
		}
	}
}
