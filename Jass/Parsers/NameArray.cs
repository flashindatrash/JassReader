using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class NameArray : IParser
	{
		public const string Pattern = @"(?<name>" + Name.Pattern + @")\s*\[\s*(?<index>" + Eval.Pattern + @")\s*\]";

		private string name;
		private string index;

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			name = match.Groups["name"].Value;
			index = match.Groups["index"].Value;
		}

		public override string ToString()
		{
			return name + "[" + index + "]";
		}
	}
}

