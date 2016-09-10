using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Set : JassLine, IParser
	{
		public const string Pattern = @"^set\s+(?<name>" + Name.Pattern + @")\s*=\s*(?<eval>" + Eval.Pattern + @")\r?$";

		private readonly Name name = new Name();
		private readonly Eval eval = new Eval();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			name.Parse(match.Groups["name"].Value);
			eval.Parse(match.Groups["eval"].Value);
		}

		public override string ToString()
		{
			return name + " = " + eval + ";";
		}

	}
}

