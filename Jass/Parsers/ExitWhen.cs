using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class ExitWhen : JassLine, IParser
	{
		public const string Pattern = @"^exitwhen\s+(?<predicate>" + Predicate.Pattern + @")\r?$";

		private readonly Predicate predicate = new Predicate();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			predicate.Parse(match.Groups["predicate"].Value);
		}

		public override string ToString()
		{
			return "if (" + predicate + ") { break; }";
		}
	}
}

