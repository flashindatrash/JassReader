using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class IfThen : IParser
	{
		public const string Pattern = @"^(?<type>if|elseif)\s+(?<predicate>" + Predicate.Pattern + @")\s+then\r?$";

		private string type;
		private readonly Predicate predicate = new Predicate();

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

	}
}

