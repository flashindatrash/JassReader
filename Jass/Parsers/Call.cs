using System;
using System.Text.RegularExpressions;

namespace Jass
{
	public class Call : IParser
	{
		public static readonly string Pattern = @"^call\s+(?<name>[\w_]+)\s*\(\s*(?<args>[^\)|\s+\)]*)\s*\)";

		private string name;
		private Args args = new Args();

		public void Parse(string text)
		{
			Match match = Regex.Match(text, Pattern);
			name = match.Groups["name"].Value;
			args.Parse(match.Groups["args"].Value);
		}
		
		public override string ToString()
		{
			return name + " (" + args + ");";
		}

	}
}

