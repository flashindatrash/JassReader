using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class IfThen : JassLine, IParser, ITabBefore, ITabAfter
	{
		public const string Pattern = @"^(?<type>if|elseif)\s+(?<predicate>" + Predicate.Pattern + @")\s+then\r?$";

		private string type;
		private readonly Predicate predicate = new Predicate();

		public bool isElse
		{
			get { return type == "elseif"; }
		}

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			type = match.Groups["type"].Value;
			predicate.Parse(match.Groups["predicate"].Value);
		}

		public override string ToString()
		{
			return (type == "elseif" ? "} else if " : "if ") + "(" + predicate + ") {";
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

