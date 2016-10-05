using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class IfThen : JassLine, IParser, ITabBefore, ITabAfter
	{
		public const string Pattern = @"^(?<type>if|elseif)\s*(?<expression>" + Eval.Pattern + @")\s*then\r?$";

		private string type;
		private readonly Eval expression = new Eval();

		public bool isElse
		{
			get { return type == "elseif"; }
		}

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			type = match.Groups["type"].Value;
			expression.Parse(match.Groups["expression"].Value);
		}

		public override string ToString()
		{
			return (type == "elseif" ? "} else if " : "if ") + "(" + expression + ") {";
		}

		public int tabBefore
		{
			get { return isElse ? 1 : 0; }
		}

		public int tabAfter
		{
			get { return 1; }
		}
	}
}

