using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class ExitWhen : JassLine, IParser
	{
		public const string Pattern = @"^exitwhen\s+(?<expression>" + Expression.Pattern + @")\r?$";

		private readonly Expression expression = new Expression();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			expression.Parse(match.Groups["expression"].Value);
		}

		public override string ToString()
		{
			return "if (" + expression + ") { break; }";
		}
	}
}

