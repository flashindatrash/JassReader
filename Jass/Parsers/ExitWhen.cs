using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class ExitWhen : JassLine, IParser
	{
		public const string Pattern = @"^exitwhen\s+(?<expression>" + Eval.Pattern + @")\r?$";

		private readonly Eval expression = new Eval();

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

