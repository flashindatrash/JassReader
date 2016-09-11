using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Return : JassLine, IParser
	{
		public const string Pattern = @"^return\s*(?<returns>" + Eval.Pattern + @")\r?$";

		private readonly Eval returns = new Eval();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			returns.Parse(match.Groups["returns"].Value.Trim());
		}

		public override string ToString()
		{
			return "return" + (returns.IsNone ? "" : " " + returns) + ";";
		}
	}
}

