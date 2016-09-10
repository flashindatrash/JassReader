using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class ExitWhen : JassLine, IParser
	{
		public const string Pattern = @"^exitwhen\s+(?<condition>" + Condition.Pattern + @")\r?$";

		private readonly Condition condition = new Condition();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			condition.Parse(match.Groups["condition"].Value);
		}

		public override string ToString()
		{
			return "if (" + condition + ") { break; }";
		}
	}
}

