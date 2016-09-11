using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class SetArray : JassLine, IParser
	{
		public const string Pattern = @"^set\s+(?<declaration>" + NameArray.Pattern + @")\s*=\s*(?<eval>" + Eval.Pattern + @")\r?$";

		private readonly NameArray declaration = new NameArray();
		private readonly Eval eval = new Eval();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			declaration.Parse(match.Groups["declaration"].Value);
			eval.Parse(match.Groups["eval"].Value);
		}

		public override string ToString()
		{
			return declaration + " = " + eval + ";";
		}

	}
}

